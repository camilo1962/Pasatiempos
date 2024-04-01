using UnityEngine;
using System.Collections;
///
/// Haga clic en el objeto y controle el movimiento
///
public class Move : MonoBehaviour
{

    // Use this for initialization
    bool isOk = false; // Valor inicial falso

    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {
        // Determinar si presionar el botón izquierdo
        if (Input.GetMouseButtonDown(0))
        {
            // Línea de lanzamiento
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                // El nombre del objeto que quiero mover se llama Esfera
                if (hit.transform.name == "PlayerPaddle")
                {
                    isOk = true;
                }
            }
        }
        // Levantar el botón izquierdo isok es falso
        if (Input.GetMouseButtonUp(0))
        {
            isOk = false;

        }

        // isok es cierto, mueve el objeto
        if (isOk)
        {
            // Obtener las coordenadas de la pantalla del objeto a mover
            Vector3 targer = Camera.main.WorldToScreenPoint(this.transform.position);

            // Obtenga las coordenadas de la pantalla del mouse y asigne el eje z de las coordenadas de la pantalla del objeto a las coordenadas del mouse
            Vector3 mouse = Input.mousePosition;
            mouse.z = targer.z;

            // Convertir las coordenadas de la pantalla del mouse en coordenadas mundiales
            Vector3 mouseScreenPos = Camera.main.ScreenToWorldPoint(mouse);
            // La posición del objeto en movimiento es igual a la posición del mouse convertida en coordenadas mundiales
            this.transform.position = mouseScreenPos;
        }


    }
}