using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Boss : MonoBehaviour
{
    public Animator anim;
   public int currentHealth = 100;
    public Slider healthBar;
    public ShakeCamera shake;
    public GameObject blood;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    

        healthBar.value = currentHealth;
    }

    public void TakeDamagee(int damagee)
    {
        currentHealth -= damagee;
        if(currentHealth <= 0)
        {
            shake.CameraShake();
            Score.BossScore();
            Destroy(gameObject);
            healthBar.value = 0;
            Instantiate(blood, transform.position, Quaternion.identity);
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag.Equals("Bullet"))
        {
            if(currentHealth >=1)
            {
                anim.SetTrigger("Hit");
            }
        }
    }
}
