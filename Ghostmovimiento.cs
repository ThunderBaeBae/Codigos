using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghostmovimiento : MonoBehaviour
{
    
    public float velocidad;

    public float alturaMaxima;
    public float alturaMinima;

    private float Direccion = 1f;

    void Update()
    {
        
        transform.Translate(Vector3.up * velocidad * Direccion * Time.deltaTime);

        if (transform.position.y >= alturaMaxima)
        {
            Direccion = -1f;  
        }
        else if (transform.position.y <= alturaMinima)
        {
            Direccion = 1f;  
        }
    }
}
