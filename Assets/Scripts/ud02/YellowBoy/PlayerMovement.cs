using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Zona de variables

    private float _speed = 3.0f,
                  _turnSpeed = 90.0f;

    private float _horizontal,
                  _vertical;

    private Animator _anim;
    private Rigidbody _rb;


    [Header("Raycast")]
    public LayerMask GroundMask;
    public float RayLength;


    [Header("Jump")]
    public float JumpForce;


    private Ray _ray;
    private RaycastHit _hit;
    private bool _isGrounded,
                 _canPlayerJump;




    private void Awake()
    {
       
        //La variable "anim" apunta al componente Animator
        // del "gameObject" que lleve este "script"
        _anim = GetComponent<Animator>();
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        InputPlayer();
        Move();
        Turn();
        Animating();
        CanJump();

    }



    private void FixedUpdate()
    {
        LaunchRaycast();
        if (_canPlayerJump)
        {
            _canPlayerJump = false;
            Jump();

        }

    }


    private void LaunchRaycast()
    {
        //El punto de pivote
        _ray.origin = transform.position;
        //Hacia abajo el rayo
        _ray.direction = -transform.up;


        if(Physics.Raycast(_ray, out _hit, RayLength))
        {

            //Puedo saltar
            _isGrounded = true;
            Debug.Log("Estoy tocando suelo");

        }

        else
        {

            _isGrounded = false;

        }


        Debug.DrawRay(_ray.origin, _ray.direction * RayLength, Color.red);

    }




    private void CanJump()
    {

        if(Input.GetKeyDown(KeyCode.Space) && _isGrounded)
        {
            _canPlayerJump = true;

        }


    }




    private void Jump()
    {

        _rb.AddForce(Vector3.up * JumpForce);

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



    private void Animating()
    {

        // el personaje se está moviendo
        if (_vertical != 0)
        {
            _anim.SetBool("IsMoving", true);

        }
        else
        {

            //"_vertical" es igual a cero, por lo tanto
            //el personaje está parado
            _anim.SetBool("IsMoving", false);

        }


    }


}
