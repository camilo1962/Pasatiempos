using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntos : MonoBehaviour
{
    public static int puntos = 0;
    public Text textoPuntos;


    public GameObject pasarNivel;
    public GameObject juegoAcabado;
    public Transform contenedorBloques;
    public SiguienteNivel siguienteNivel;

    public Ball1 pelota;
    public Player player;

    void Start()
    {
        ActualizarMarcadorPuntos();
    }


    void ActualizarMarcadorPuntos()
    {
        textoPuntos.text = "Puntos: " + Puntos.puntos;
    }

    public void GanarPunto()
    {
        Puntos.puntos++;
        ActualizarMarcadorPuntos();

        if(contenedorBloques.childCount <= 0)
        {
            pelota.DetenerMovimiento();
            player.enabled = false;

            if (siguienteNivel.EsUltimoNivel())
            {
                juegoAcabado.SetActive(true);
            }
            else
            {
                pasarNivel.SetActive(true);
            }

            siguienteNivel.ActivarCarga();
                
        }
    }
}
