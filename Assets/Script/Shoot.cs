using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bullet;
    public float bulletSpeed;
    public Transform shootingPoint;
    

    Vector2 direction;
    // Update is called once per frame
    void Update()
    {
        PointToMouse();
        if(Input.GetMouseButtonDown(0))
        {
            Shooting();
        }
    }

    void PointToMouse()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        direction = mousePos - (Vector2)transform.position;
        transform.right = direction;
    }

    void Shooting()
    {
        GameObject bulletins = Instantiate(bullet, shootingPoint.position, shootingPoint.rotation);
        bulletins.GetComponent<Rigidbody2D>().AddForce(bulletins.transform.right * bulletSpeed);

        Destroy(bulletins, 5);
    }
}
