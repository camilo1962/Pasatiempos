using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoSolucion : MonoBehaviour
{

    public GameObject info;
    void Start()
    {
        info.SetActive(false);
    }

    public void ActivarInfo()
    {
        if(info != null)
        {
            bool IsActive = info.activeSelf;
            info.SetActive(!IsActive);
        }
    }
}
