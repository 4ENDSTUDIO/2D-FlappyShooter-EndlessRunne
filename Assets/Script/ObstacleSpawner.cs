using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public float maxTime = 1;
    private float timer = 1;
    public GameObject pipe, virus;
    public float height, heighVirus;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > maxTime)
        {
            GameObject newVirus = Instantiate(virus);
            GameObject newPipe = Instantiate(pipe);
            newVirus.transform.position = transform.position + new Vector3(0, Random.Range(-heighVirus, heighVirus), 0);
            newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newPipe, 10);
            Destroy(newVirus, 10);
            timer = 0;
        }
        timer += Time.deltaTime;
    }
}
