using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DescendingOrder : MonoBehaviour
{
    //Variables globales

    public int num1, num2, num3;

    void Start()
    {
        if (num1 > num2 && num2 > num3)
        {
            Debug.Log("Los n�meros se han introducido en orden decreciente.");
        }
        else
        {
            Debug.Log("Los n�meros no se han introducido en orden decreciente.");
        }
    }

}
