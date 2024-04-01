using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Ball1: MonoBehaviour
{
    public Rigidbody2D rig;

    public float VelocidadInicial = 300;
    bool enJuego;

    private Vector2 velocity;
    Vector2 posicionInicial;
    public Transform player;

    void Start()
    {
        posicionInicial = transform.position;
        ResetBall1();      
    }

   
    public void OnCollisionEnter2D(Collision2D col)
    {       
        if (col.gameObject.CompareTag("DeadZone"))
        {

            FindObjectOfType<GameManager3>().PerderVida();
        }    
        
    }

    public void DetenerMovimiento()
    {
        rig.isKinematic = true;
        rig.velocity = Vector2.zero;
    }



    private void Update()
    {
        if (!enJuego && Input.GetButtonDown("Fire1"))
        {
            enJuego = true;
            transform.SetParent(null);
            rig.isKinematic = false;
            rig.AddForce(new Vector3(VelocidadInicial, VelocidadInicial, 0));
        }
    }


    public void ResetBall1()
    {
        transform.position = posicionInicial;
        //transform.SetParent(player);
        enJuego = false;
        DetenerMovimiento();
        //velocity.x = Random.Range(-1f, 1f);
        //velocity.y = 1f;
        
        rig.AddForce(velocity * VelocidadInicial);
    }

   
    
}
