using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    //Zona de variables globales

    public Transform Target;

    //Velocidad de seguimiento que va a tener la cámara
    public float _smoothing;

    //Calcular la distancia inicial entre la cámara y el "target" ("player")
    private Vector3 _offset;



    // Start is called before the first frame update
    void Start()
    {

        //El "offset" = posición de la cámara - posición del "player"
        //Es lo mismo que decir que es el vector que los une
        _offset = transform.position - Target.position;
        _smoothing = 2.5f;

    }

    // Update is called once per frame
    void Update()
    {
        //La posición a la que quiero mover la cámara
        Vector3 camPosition = Target.position + _offset;
        transform.position = Vector3.Lerp(transform.position, camPosition, _smoothing * Time.deltaTime);

    }
}
