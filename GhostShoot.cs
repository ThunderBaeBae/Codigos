using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostShoot : MonoBehaviour
{

    public GameObject bullet;  
    public float shootInterval = 2f;   
    private float timeSinceLastShot = 0f;  

    
    void Start()
    {
       
        timeSinceLastShot = 0f;
    }

    
    void Update()
    {
            timeSinceLastShot += Time.deltaTime;

       
        if (timeSinceLastShot >= shootInterval)
        {
            Instantiate(bullet, transform.position, Quaternion.identity);

            timeSinceLastShot = 0f;
        }
    }
}
