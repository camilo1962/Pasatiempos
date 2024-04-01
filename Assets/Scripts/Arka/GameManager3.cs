using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager3 : MonoBehaviour
{

    public static int vidas = 3;
    public Text textoVidas;

    public Player player;
    public Ball1 pelota;

    public GameObject gameOver;
    public SiguienteNivel siguienteNivel;
    

    private void Start()
    {
        ActualizarMarcadorVidas();
        
    }

    void ActualizarMarcadorVidas()
    {
        textoVidas.text = "Vidas: " + vidas;
    }

    public void PerderVida()
    {
        if (vidas <= 0) return;

        vidas--;
        ActualizarMarcadorVidas();

        if (vidas <= 0)
        {
            gameOver.SetActive(true);
            pelota.DetenerMovimiento();
            player.enabled = false;

            siguienteNivel.nivelACargar = "PortadaArkanoid";
            siguienteNivel.ActivarCarga();
        }
        else
        {
            ResetNivel();
        }
        return;
    }
    public void ResetNivel()
    {
        pelota.ResetBall1();
        player.ResetPlayer();
        
       
    }

    public void CheckLevelCompleted()
    {
        if (transform.childCount <= 1)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
     

    
    
}
