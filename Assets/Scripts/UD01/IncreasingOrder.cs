using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreasingOrder : MonoBehaviour
{
   //Variables globales

    public int num1, num2, num3;

    void Start()
    {
        if (num1 < num2 && num2 < num3)
        {
            Debug.Log("Los n�meros se han introducido en orden creciente.");
        }
        else
        {
            Debug.Log("Los n�meros no se han introducido en orden creciente.");
        }
    }

}
