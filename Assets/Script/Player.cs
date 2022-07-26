using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameManager gameManager;
    public float velocity = 1;
    private Rigidbody2D rb;
    public GameObject Smoke;
    void Start()
    {
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
        gameManager.GameOver(); 
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Point")
        {
            Score.score++;
        }
    }


}
