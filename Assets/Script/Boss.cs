using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Boss : MonoBehaviour
{
    
   public int currentHealth = 100;
    public Slider healthBar;

    
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
            Score.BossScore();
            Destroy(gameObject);
            healthBar.value = 0;
        }
    }
}
