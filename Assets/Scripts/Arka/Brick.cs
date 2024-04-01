using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{

    public int numCols = 1;

    public int numTicks = 0;
    public Puntos puntos;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            numTicks++;
            if (numTicks < numCols) return;
            FindObjectOfType<GameManager3>().CheckLevelCompleted();
            Destroy(gameObject);
            transform.SetParent(null);
            puntos.GanarPunto();

        }
    }


}
