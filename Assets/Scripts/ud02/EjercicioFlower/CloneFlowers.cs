using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloneFlowers : MonoBehaviour
{

    //Zona de variables globales
    public GameObject Flower;
    public Transform PosRotFlower;

    public float thrustY,
                 thrustZ;

    private float timeFlower = 3.0f;



    // Update is called once per frame
    void Update()
    {

        CreateFlowers();

    }


    private void CreateFlowers()
    {

        if (Input.GetMouseButtonDown(0))
        {

        //Crear clones del prefabricados de la flor. Siempre para crear
        //instancias se utilizan "Prefabs" no modelos, ya que eso estaría mal

        //Como no se indica donde se va a generar el clon,
        //se crea en la posición (0.0f, 0.0f, 0.0f) del mundo

        GameObject cloneFlower = Instantiate(Flower, PosRotFlower.position, PosRotFlower.rotation);


        //Obtengo el componente "rigibody" de cada bellota

        Rigidbody rbFlower = cloneFlower.GetComponent<Rigidbody>();



        //"Vector3.up" hace referencia al eje Y global de la escena
        rbFlower.AddForce(Vector3.up * thrustY);

        //"transform.forward" hace referencia al eje Z local de "PosRotAcorn"
        rbFlower.AddForce(transform.forward * thrustZ);


        //con las dos anteriores combinadas se consigue un desplazamiento
        //del tiro en forma de parábola o arco



        Destroy(cloneFlower, timeFlower);
        //La bellota disparada se destruye de acuerdo al tiempo asignado

        }

    }


}
