using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleRaycast : MonoBehaviour
{

    //Zona de variables globales

    //Variable donde se guarda la información del ray
    private Ray _ray;

    //Aquí, en "RaycastHit" se guarda la info de la colisión entre
    //el "raycast" y el "collider" del objeto
    private RaycastHit _hit;

    public float RayLength;
    public LayerMask RayMask;
    public float ForceEnemy;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        _ray.origin = transform.position;
        _ray.direction = transform.forward;


        if (Physics.Raycast(_ray, out _hit, RayLength, RayMask))
        {
            Debug.Log("Estoy chocando con " + _hit.collider.name);
            Debug.Log("Punto de impacto:" + _hit.point);
            Debug.Log("Distancia: " + _hit.distance);
            _hit.collider.GetComponent<Rigidbody>().AddForce(Vector3.up * ForceEnemy);

        }


        Debug.DrawRay(_ray.origin, _ray.direction * RayLength, Color.red);


    }
}
