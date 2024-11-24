using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloneEggs : MonoBehaviour
{

    //Zona de variables globales
    public GameObject Egg;
    public Transform PosRotEgg;

    public float thrustY,
                 thrustZ;

    private float timeEgg = 3.0f;



    // Update is called once per frame
    void Update()
    {

        CreateEggs();

    }


    private void CreateEggs()
    {

        if (Input.GetMouseButtonDown(0))
        {

        //Crear clones del prefabricados del huevo. Siempre para crear
        //instancias se utilizan "Prefabs" no modelos, ya que eso estaría mal

        //Como no se indica donde se va a generar el clon,
        //se crea en la posición (0.0f, 0.0f, 0.0f) del mundo

        GameObject cloneEgg = Instantiate(Egg, PosRotEgg.position, PosRotEgg.rotation);


        //Obtengo el componente "rigibody" de cada bellota

        Rigidbody rbEgg = cloneEgg.GetComponent<Rigidbody>();



        //"Vector3.up" hace referencia al eje Y global de la escena
        rbEgg.AddForce(Vector3.up * thrustY);

        //"transform.forward" hace referencia al eje Z local de "PosRotAcorn"
        rbEgg.AddForce(transform.forward * thrustZ);


        //con las dos anteriores combinadas se consigue un desplazamiento
        //del tiro en forma de parábola o arco



        Destroy(cloneEgg, timeEgg);
        //La bellota disparada se destruye de acuerdo al tiempo asignado

        }

    }


}
