using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clone : MonoBehaviour
{

    //Zona de variables globales
    public GameObject Acorn;
    public Transform PosRotAcorn;

    public float thrustY,
                 thrustZ;

    private float timeAcorn = 3.0f;

    private float timeInvoke = 2.0f;

    private float timeRepeating = 5.0f;


    private void Start()
    {

        //Invoke("CreateAcorns", timeInvoke);

        InvokeRepeating("CreateAcorns", timeInvoke, timeRepeating);
    }



    // Update is called once per frame
    void Update()
    {

        //CreateAcorns();

    }


    private void CreateAcorns()
    {

        //if (Input.GetMouseButtonDown(0))
        //{

            //Crear clones del prefabricados de la bellota. Siempre para crear
            //instancias se utilizan "Prefabs" no modelos, ya que eso estaría mal

            //Como no se indica donde se va a generar el clon,
            //se crea en la posición (0.0f, 0.0f, 0.0f) del mundo

            GameObject cloneAcorn = Instantiate(Acorn, PosRotAcorn.position, PosRotAcorn.rotation);


            //Obtengo el componente "rigibody" de cada bellota

            Rigidbody rbAcorn = cloneAcorn.GetComponent<Rigidbody>();

           
            
            //"Vector3.up" hace referencia al eje Y global de la escena
            rbAcorn.AddForce(Vector3.up * thrustY);

            //"transform.forward" hace referencia al eje Z local de "PosRotAcorn"
            rbAcorn.AddForce(transform.forward * thrustZ);


            //con las dos anteriores combinadas se consigue un desplazamiento
            //del tiro en forma de parábola o arco



            Destroy(cloneAcorn, timeAcorn); 
            //La bellota disparada se destruye de acuerdo al tiempo asignado

        //}

    }




}
