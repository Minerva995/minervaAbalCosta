using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flower : MonoBehaviour
{
    //Zona de variables globales
    public Material Mat;



    private void OnTriggerEnter(Collider infoAcces)
    {
        Debug.Log("Estoy haciendo una colisi�n Trigger con: " + infoAcces.gameObject.name);

        //Identificar mediante etiqueta el objeto contra el que est� chocando
        if (infoAcces.CompareTag("Enemy"))
        {

            //Ese "infoAccess.gameObject" est� haciendo referencia al cubo
            Destroy(infoAcces.gameObject);
        }

    }
}



