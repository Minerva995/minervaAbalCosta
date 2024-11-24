using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfAttack : MonoBehaviour
{

    //Zona de variables globales

    public GameObject Flower;
    public Transform PosRotFlower;
    private float thrustY = 300.0f;
    private float thrustZ = 150.0f;
    private float timeFlower = 4.0f;
    private Animator anim;
    public Collider ColliderAttack;


    private void Awake()
    {
        anim = GetComponent<Animator>();
    }



    // Update is called once per frame
    void Update()
    {

        CreateFlowers();

        if (Input.GetMouseButton(0))
        {
            Attack();
        }

    }


    private void CreateFlowers()
    {

        if (Input.GetMouseButtonDown(0))
        {

            GameObject cloneFlower = Instantiate(Flower, PosRotFlower.position, PosRotFlower.rotation);

            //El componente "rigidbody" con el que voy a trabajar es el de los clones de la pelota
            Rigidbody rbFlower = cloneFlower.GetComponent<Rigidbody>();


            //"Vector3" para hacer referencia al eje Y global de la escena
            rbFlower.AddForce(Vector3.up * thrustY);


            //"transform.forward" para hacer referencia al eje Z de "PosRotBall"
            rbFlower.AddForce(transform.forward * thrustZ);

            //Destruir la bola
            Destroy(cloneFlower, timeFlower);

        }

        
    }


    private void Attack()
    {
        //Ejecutar la animacion de ataque

        anim.SetTrigger("Attack");

    }


    //Eventos en la animacion
    private void EnableCollider()
    {

        //Habilita el componente para que el
        //"collider" actúa en la escena
        ColliderAttack.enabled = true;

    }


    private void DisableCollider()
    {

        //Deshabilita el componente para que el
        //"collider" actúa en la escena
        ColliderAttack.enabled = false;

    }




}
