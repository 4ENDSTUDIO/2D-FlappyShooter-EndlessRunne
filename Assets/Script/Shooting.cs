using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class Shooting : MonoBehaviour
{
    public Transform Gun;
    Vector2 direction;
    public GameObject bullet;
    public float bulletSpeed;
    public Transform ShootPoint;
    public float fireRate;
    float readyForNextShot;
    public Animator gunAnimator;
      public Joystick joystik;
    float angle;

    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        
        Vector3 moveVector = (Vector3.left * joystik.Vertical + Vector3.up * joystik.Horizontal);

        if(joystik.Horizontal >= .2f && joystik.Horizontal >= -.2f)
        {
            if (Time.time > readyForNextShot)
            {
                readyForNextShot = Time.time + 1 / fireRate;
                Shoot();
            }
        }

        if (joystik.Vertical >= -.2f && joystik.Vertical >= .2f)
        {
            if (Time.time > readyForNextShot)
            {
                readyForNextShot = Time.time + 1 / fireRate;
                Shoot();
            }
        }
        if (joystik.Horizontal != 0 || joystik.Vertical != 0)

        {

            Gun.transform.rotation = Quaternion.LookRotation(Vector3.forward, moveVector);

        }






         
            
        
    }

   



  
    void Shoot()
    {
        gunAnimator.SetTrigger("Shoot"); 
       GameObject BulletIns =  Instantiate(bullet, ShootPoint.position, ShootPoint.rotation);
        BulletIns.GetComponent<Rigidbody2D>().AddForce(BulletIns.transform.right * bulletSpeed);

        Destroy(BulletIns, 2);
    }
}
