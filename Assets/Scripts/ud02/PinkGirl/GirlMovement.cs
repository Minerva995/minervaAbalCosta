using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;

public class GirlMovement : MonoBehaviour
{

    //Zona de variables
    private float _horizontal;
    private float _vertical;
    private float _speed = 3.0f;
    private float _turnSpeed = 90.0f;


    // Update is called once per frame
    void Update()
    {
        
        InputPlayer();
        Move();
        Turn();

    }


    private void InputPlayer()
    {

        //Teclas A y D y las flechas < y > se van a usar

        _horizontal = Input.GetAxis("Horizontal");

        //Teclas W y S y las felchas arriba y abajo en cruzeta
        _vertical = Input.GetAxis("Vertical");

    }


    private void Move()
    {

        //Aplicamos el valor del eje vertical al "translate"
        transform.Translate(Vector3.forward * _vertical * _speed * Time.deltaTime);


    }


    private void Turn()
    {
        //Aplicamos el valor del eje horizontal al "rotate"
        transform.Rotate(Vector3.up * _horizontal * _turnSpeed * Time.deltaTime);

    }

}
