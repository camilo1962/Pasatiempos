using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public Rigidbody2D rigidbody2D;

    private float inputValue;

    public float velocidad = 0.4f;

    public Vector2 direction;
    Vector2 posicionInicial;

    public ElementoInteractivo botonIzquierda;
    public ElementoInteractivo botonDerecha;

    private void Start()
    {
        posicionInicial = transform.position;
    }


    void Update()
    {
        float direccion;
        if (botonIzquierda.pulsado)
        {
            direccion = -1;
        } else if (botonDerecha.pulsado)
        {
            direccion = 1;
        }
        else
        {
            direccion = Input.GetAxisRaw("Horizontal");
        }

        float tecladoHorizontal = Input.GetAxisRaw("Horizontal");
        float posX = transform.position.x + (tecladoHorizontal * velocidad * Time.deltaTime);
        transform.position = new Vector3(Mathf.Clamp(posX, -8, 8), transform.position.y, transform.position.z);
      

        

    }

    public void ResetPlayer()
    {
        transform.position = posicionInicial;
        rigidbody2D.velocity = Vector2.zero;
    }
}
