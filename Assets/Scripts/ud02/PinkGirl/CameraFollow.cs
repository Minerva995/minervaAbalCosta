using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    //Zona de variables globales

    public Transform Target;

    //Velocidad de seguimiento que va a tener la c�mara
    public float _smoothing;

    //Calcular la distancia inicial entre la c�mara y el "target" ("player")
    private Vector3 _offset;



    // Start is called before the first frame update
    void Start()
    {

        //El "offset" = posici�n de la c�mara - posici�n del "player"
        //Es lo mismo que decir que es el vector que los une
        _offset = transform.position - Target.position;
        _smoothing = 2.5f;

    }

    // Update is called once per frame
    void Update()
    {
        //La posici�n a la que quiero mover la c�mara
        Vector3 camPosition = Target.position + _offset;
        transform.position = Vector3.Lerp(transform.position, camPosition, _smoothing * Time.deltaTime);

    }
}
