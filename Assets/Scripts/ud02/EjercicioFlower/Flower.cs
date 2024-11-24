using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flower : MonoBehaviour
{
    //Zona de variables globales
    public Material Mat;



    private void OnTriggerEnter(Collider infoAcces)
    {
        Debug.Log("Estoy haciendo una colisión Trigger con: " + infoAcces.gameObject.name);

        //Identificar mediante etiqueta el objeto contra el que está chocando
        if (infoAcces.CompareTag("Enemy"))
        {

            //Ese "infoAccess.gameObject" está haciendo referencia al cubo
            Destroy(infoAcces.gameObject);
        }

    }
}



