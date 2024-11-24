using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoyAttack : MonoBehaviour
{

    //Zona de variables globales

    private Animator anim;
    public Collider ColliderAttack;


    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

  

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Attack();
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
