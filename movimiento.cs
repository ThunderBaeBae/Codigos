using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento : MonoBehaviour
{
    public Rigidbody2D RB;
    public float speed;
    public float x;
    public float y;
    public float upLimit, downLimit, leftLimit, rightLimit;

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");
    }

   private void FixedUpdate()
    {
        RB.velocity = new Vector2 (x, y) * speed;
        CheckLimits();
    }

    public void CheckLimits()
    {
        if (transform.position.x > rightLimit)
        {
            transform.position = new Vector2 (rightLimit, transform.position.y);
        }

        if (transform.position.x < leftLimit)
        {
            transform.position = new Vector2(leftLimit, transform.position.y);
        }

        if (transform.position.y > upLimit)
        {
            transform.position = new Vector2(transform.position.x,upLimit);
        }

        if (transform.position.y < downLimit)
        {
            transform.position = new Vector2(transform.position.x,downLimit);
        }

    }
 
}
