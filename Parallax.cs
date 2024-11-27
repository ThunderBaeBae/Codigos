using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    public float parallaxVelocity;
    Renderer rendererParallax;
    void Start()
    {
        rendererParallax = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        rendererParallax.material.mainTextureOffset = new Vector2(Time.time * parallaxVelocity, 0);
    }
}
