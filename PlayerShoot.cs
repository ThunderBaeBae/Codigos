using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject bullet;
    public AudioSource source;
    public AudioClip bulletClip;
    public float shootTime;
    public float shootLimit;
        
    
    
    void Update()
    {
        shootTime += Time.deltaTime;


        if (Input.GetKey(KeyCode.Space) && shootTime > shootLimit)
        {
            shootTime = 0;  
            Instantiate(bullet, transform.position, Quaternion.identity);
            source.PlayOneShot(bulletClip, 0.10f);
        }
    }
}
