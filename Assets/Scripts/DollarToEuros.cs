using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DollarToEuros : MonoBehaviour
{

    //variables globales
    private float _euro;
    public float Dollar;

    // Start is called before the first frame update
    void Start()
    {
        _euro = 0.90f;
        Debug.Log(GetDollarToEuro());

    }

    private float GetDollarToEuro()
    {
        //variables locales
        float conversion = 0.0f;

        //Calcular conversion de dólares a euros
        conversion = Dollar * _euro;

        //Devolver el valor de tipo "float"
        return conversion;




    }
}
