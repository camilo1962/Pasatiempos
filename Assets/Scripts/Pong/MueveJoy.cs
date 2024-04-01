using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MueveJoy : MonoBehaviour
{

    public Joystick joystick;
    public Rigidbody2D rb;
    public int velocidad;
    public bool ConFisicas;

    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        Vector2 direction = Vector2.up * joystick.Vertical + Vector2.right * joystick.Horizontal;
        if (ConFisicas)
        {
            rb.AddForce(direction * velocidad * Time.fixedDeltaTime, ForceMode2D.Impulse);
        }
        else
        {
            gameObject.transform.Translate(direction * velocidad * Time.deltaTime);
        }
    }
}
