using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Addition : MonoBehaviour
{

    //Varibales globales
    public int Number;

    // Start is called before the first frame update
    void Start()
    {

        int sum = 0;
        for (int i = 1; i <= Number; i++)
        {
            sum += i;
        }
        Debug.Log("The sum of numbers from 1 to " + Number + " is: " + sum);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
