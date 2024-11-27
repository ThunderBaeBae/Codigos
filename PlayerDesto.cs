using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDesto : MonoBehaviour
{
   private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 10 || collision.gameObject.layer == 11 || collision.gameObject.layer == 12 || collision.gameObject.layer == 13)
        {
            FindObjectOfType<PlayerManager>().CreateANewPlayer();
            Destroy(gameObject);
        }
    }
}
