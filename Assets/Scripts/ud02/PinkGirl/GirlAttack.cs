using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GirlAttack : MonoBehaviour
{

    //Zona de variables globales

    public GameObject Ball;
    public Transform PosRotBall;
    private float thrustY = 100.0f;
    private float thrustZ = 300.0f;
    private float timeBall = 5.0f;

    
    
  

    // Update is called once per frame
    void Update()
    {

        CreateBalls();



    }


    private void CreateBalls()
    {

        if (Input.GetMouseButtonDown(0))
        {

            GameObject cloneBall = Instantiate(Ball, PosRotBall.position, PosRotBall.rotation);

            //El componente "rigidbody" con el que voy a trabajar es el de los clones de la pelota
            Rigidbody rbBall = cloneBall.GetComponent<Rigidbody>();


            //"Vector3" para hacer referencia al eje Y global de la escena
            rbBall.AddForce(Vector3.up * thrustY);


            //"transform.forward" para hacer referencia al eje Z de "PosRotBall"
            rbBall.AddForce(transform.forward * thrustZ);

            //Destruir la bola
            Destroy(cloneBall, timeBall);

        }

        
    }



}
