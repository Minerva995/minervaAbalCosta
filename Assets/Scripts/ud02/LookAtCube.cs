using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCube : MonoBehaviour
{

    //Zona de variables globales

    public Transform MyCube;

    //Transform con mayuscula es una clase, en este caso es un tipo de referencia de recurso a escena porque es un componente


    // Update is called once per frame
    void Update()
    {

        TransformLook();


    }


    private void TransformLook()
    {

        transform.LookAt(MyCube);

    }



}
