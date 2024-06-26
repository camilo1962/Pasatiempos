using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SiguienteNivel : MonoBehaviour
{

    public string nivelACargar;
    public float retraso;

    public void ActivarCarga()
    {
        Invoke("CargarNivel", retraso);
    }

    void CargarNivel()
    {
        Application.LoadLevel(nivelACargar);
    }

    public bool EsUltimoNivel()
    {
        return nivelACargar == "PortadaArkanoid";
    }
}
