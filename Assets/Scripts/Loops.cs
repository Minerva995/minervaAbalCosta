using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{

    //Variables globales
    public int Number;
    
    
    // Start is called before the first frame update
    void Start()
    {
        //GetNumber0To100While();
        GetNumber0To100For();
    }

    private void GetNumber0To100While()
    {
        //Crear e inicializar la variable incremento
        int i = 0;

        //Crear el "while"

        while(i < 101)
        {
            Debug.Log(i);
            i++;// i + 1;

        }

    }




    private void GetNumber0To100For()
    {


    }


   
}
