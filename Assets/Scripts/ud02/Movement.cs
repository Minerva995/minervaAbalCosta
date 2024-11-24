using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    //Zona de variables
    [SerializeField]
    private float _speed = 0.8f;
    [SerializeField]
    private float _turn = 300.0f;
    //public KeyCode MyKey;
    //public Space MySpace;
    //public ForceMode MyForceMode;



    //Si no se indica el _turn, la velocidad de giro sería igual a la velocidad de translación si lo indicamos en transform.Rotate con _speed en vez de _turn. Y sería demasiado lento el giro en este caso.

    // Update is called once per frame
    void Update()
    {

        // transform.Translate (Vector3) x, y, z
        //Vector unitario o Vector normalizado o Vector unidad



        //GetKey sería una metralladora, es continuo, GetKeyDown sería una pistola, un click por traslación
        //Hacia delante
        if (Input.GetKey(KeyCode.W))
        {
             //new Vector3(0.0f, 0.0f, 1.0f);

            transform.Translate(Vector3.forward * Time.deltaTime);

        }


        //Hacia atrás
        if (Input.GetKey(KeyCode.S))
        {
            //new Vector3(0.0f, 0.0f, 1.0f);

            transform.Translate(Vector3.back * Time.deltaTime);

        }

        //Girar a la izquierda teniendo en cuenta el eje Y (up)
        if (Input.GetKey(KeyCode.A))
        {
            //new Vector3(0.0f, 0.0f, 1.0f);

            transform.Rotate(-Vector3.up * _turn * Time.deltaTime);

        }


        //Girar a la derecha teniendo en cuenta el eje Y (up)
        if (Input.GetKey(KeyCode.D))
        {
            //new Vector3(0.0f, 0.0f, 1.0f);

            transform.Rotate(Vector3.up * _turn * Time.deltaTime);

        }


        //Gira en Y con "up", como si fuera una bailarina. Por cierto todo lo que sea movimiento se va a tener que multiplicar por Time.deltaTime
        //transform.Rotate(Vector3.up * _turn * Time.deltaTime, Space.World);



    }
}
