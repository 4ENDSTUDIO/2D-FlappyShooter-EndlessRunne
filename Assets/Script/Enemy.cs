using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int maxHealth = 100;
    int currentHealth;
    public Animator anim;
    public GameObject blood;
    private ShakeCamera shake;
    void Start()
    {
        shake = GameObject.FindGameObjectWithTag("GameManager").GetComponent<ShakeCamera>();
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if(currentHealth <= 0)
        {
            shake.CameraShake();
            Instantiate(blood, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag.Equals("Bullet"))
        {
            if(currentHealth >= 1)
            {
                anim.SetTrigger("Hit");
            }
        }

        
    }
}
