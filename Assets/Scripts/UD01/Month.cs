using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Month : MonoBehaviour
{
    //Zona de variables globales
    
    public int NumberMonth;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        IsNumberMonth();

    }


    private void IsNumberMonth()
    {

        switch (NumberMonth)
        {

            case 1:
                Debug.Log("Enero");
                break;

            case 2:
                Debug.Log("Febrero");
                break;

            case 3:
                Debug.Log("Marzo");
                break;

            case 4:
                Debug.Log("Abril");
                break;

            case 5:
                Debug.Log("Mayo");
                break;

            case 6:
                Debug.Log("Junio");
                break;

            case 7:
                Debug.Log("Julio");
                break;


            case 8:
                Debug.Log("Agosto");
                break;

            case 9:
                Debug.Log("Septiembre");
                break;

            case 10:
                Debug.Log("Octubre");
                break;

            case 11:
                Debug.Log("Noviembre");
                break;

            case 12:
                Debug.Log("Diciembre");
                break;

            default:
                Debug.Log("El n�mero introducido no se corresponde con ning�n mes.");
                break;


        }


    }


}

