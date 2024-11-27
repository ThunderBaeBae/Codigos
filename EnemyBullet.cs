using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public Rigidbody2D RB;
    public Vector2 BulletVelocity;


    void Start()
    {
        RB.velocity = BulletVelocity;
    }


    void Update()
    {
        if (transform.position.x < -9.8)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 9)
        {
            Destroy(gameObject);
        }
        
    }

}
