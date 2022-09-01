using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameManager gameManager;
    public float velocity = 1;
    private Rigidbody2D rb;
    public GameObject Smoke;
    public GameObject heart1, heart2, heart3;
    public int playerHealth = 3;
    int playerLayer, enemyLayer;
    bool coroutineAllowed = true;
    Color color;
    Renderer rend;
    private ShakeCamera shake;
    
    void Start()
    {
        shake = GameObject.FindGameObjectWithTag("GameManager").GetComponent<ShakeCamera>();
        playerLayer = this.gameObject.layer;
        enemyLayer = LayerMask.NameToLayer("Enemy");
        Physics2D.IgnoreLayerCollision(playerLayer, enemyLayer, false);
        heart1.gameObject.SetActive(true);
        heart2.gameObject.SetActive(true);
        heart3.gameObject.SetActive(true);
        rend = GetComponent<Renderer>();
        color = rend.material.color;


        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    public void ControlPlayer()
    {
        rb.velocity = Vector2.up * velocity;
        Instantiate(Smoke, transform.position, Quaternion.identity);
       
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag.Equals("Enemy") || (collision.gameObject.tag.Equals("Virus") ))
        {
            playerHealth -= 1;
            shake.CameraShake();
            switch (playerHealth)
            {
                case 2:
                    heart3.gameObject.SetActive(false);
                    if (coroutineAllowed)
                        StartCoroutine("Immortal");
                    break;
                case 1:
                    heart2.gameObject.SetActive(false);
                    if (coroutineAllowed)
                        StartCoroutine("Immortal");
                    break;
                case 0:
                    heart1.gameObject.SetActive(false);
                    if (coroutineAllowed)
                        StartCoroutine("Immortal");
                    break;
            }
            if(playerHealth < 1)
            {
                shake.CameraShake();
                gameManager.GameOver();
            }
           
        }
         
    }

    IEnumerator Immortal()
    {
        coroutineAllowed = false;
        Physics2D.IgnoreLayerCollision(playerLayer, enemyLayer, true);
        color.a = 0.5f;
        rend.material.color = color;
        yield return new WaitForSeconds(3f);
        Physics2D.IgnoreLayerCollision(playerLayer, enemyLayer, false);
        color.a = 1f;
        rend.material.color = color;
        coroutineAllowed = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Point")
        {
            Score.score++;
        }
    }


}
