using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
   public Rigidbody2D RB;
    public Vector2 BulletVelocity;


    void Start()
    {
        RB.velocity = BulletVelocity;  
    }

   
    void Update()
    {
        if (transform.position.x > 9.5)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 10)
        {

            collision.gameObject.GetComponent<GhostLife>().HurtEnemy();
          
            Destroy(gameObject);

        }
        if (collision.gameObject.layer == 11)
        {
            collision.gameObject.GetComponent<CrownLife>().HurtEnemy();
            
        }

        if(collision.gameObject.layer == 12)
        {
            collision.gameObject.GetComponent<SkullLife>().HurtEnemy();
        }
    }

}
