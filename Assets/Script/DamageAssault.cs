using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageAssault : MonoBehaviour
{
    public int attackShoot = 20;
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
 

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag.Equals("Virus"))
        {
            collision.collider.GetComponent<Enemy>().TakeDamage(attackShoot);
        }
        if (collision.gameObject.tag.Equals("Boss"))
        {
            collision.collider.GetComponent<Boss>().TakeDamagee(attackShoot);
        }

    }
}
