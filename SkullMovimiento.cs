using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkullMovimiento : MonoBehaviour
{
    public Rigidbody2D RB;
    public Vector2 enemyVelocity;

    void Start()
    {
        RB.velocity = enemyVelocity;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -11)
        {
            Destroy(gameObject);
        }
    }
}
