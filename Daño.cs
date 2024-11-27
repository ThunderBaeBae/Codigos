using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Daño : MonoBehaviour
{
    
    private SpriteRenderer spriteRenderer;

    
    private Color colorOriginal;

   
    public Color colorColision = Color.red;

    public float tiempoCambioColor = 1f;

    private bool cambiandoColor = false;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        colorOriginal = spriteRenderer.color;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 14)
        {
            if (!cambiandoColor)
            {
                StartCoroutine(CambiarColorTemporalmente());
            }
        }
    }

    IEnumerator CambiarColorTemporalmente()
    {
        cambiandoColor = true;

        spriteRenderer.color = colorColision;

        yield return new WaitForSeconds(tiempoCambioColor);

        spriteRenderer.color = colorOriginal;

        cambiandoColor = false;
    }
}