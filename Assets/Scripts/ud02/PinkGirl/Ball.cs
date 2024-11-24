using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    //Zona de variables globales
    public Material Mat;


    /*private void OnCollisionEnter(Collision infoCollision)
    {

        Debug.Log("He colisionado con " + infoCollision.gameObject.name);

        //Voy a ver si estoy chocando contra el cubo
        //Acceder al "collider" del objeto con el que está chocando la bala
        // y mirar si la etiqueta es igual a "Enemy"

        if (infoCollision.collider.CompareTag("Enemy"))
        {
            //Cambiar el material del cubo
            //Acceder a su componente "Renderer" y a su propiedad "material"

            infoCollision.gameObject.GetComponent<Renderer>().material = Mat;


        }

    }*/


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
