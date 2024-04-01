using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ElementoInteractivo : MonoBehaviour, IPointerDownHandler, IPointerUpHandler 
{

    public bool pulsado;

    void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
    {
        pulsado = true;
    }

    void IPointerUpHandler.OnPointerUp(PointerEventData eventData)
    {
        pulsado = false;
    }

    
}

