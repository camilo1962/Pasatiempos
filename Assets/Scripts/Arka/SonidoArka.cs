using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidoArka : MonoBehaviour
{
    public AudioSource pelota;
    public AudioSource point;
    public AudioSource fallo;

        


    public void OnCollisionEnter2D(Collision2D col)
    {
               
        if (col.gameObject.CompareTag("Racket"))
        {
            pelota.Play();
        }
        else if (col.gameObject.CompareTag("Block"))
        {
            point.Play();
        }
        else if (col.gameObject.CompareTag("DeadZone"))
        {
           fallo.Play();
        }
    }


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
