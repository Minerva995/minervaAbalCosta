using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActive : MonoBehaviour
{

    //Zona de variables globales
    public GameObject myCamera;


    private void Start()
    {

        gameObject.SetActive(false);

    }




    // Update is called once per frame
    void Update()
    {

        ActivateCamera();

    }

    private void ActivateCamera()
    {
        //Desactivo el renderizado de la camara con la barra espaciadora
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myCamera.SetActive(false);

        }


        //Activo el renderizado de la camara
        if (Input.GetKeyDown(KeyCode.E))
        {
            myCamera.SetActive(true);

        }


    }

    

}
