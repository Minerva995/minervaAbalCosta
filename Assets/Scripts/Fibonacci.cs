using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fibonacci : MonoBehaviour
{
    //Variables globales
    public int Position;


    // Start is called before the first frame update
    void Start()
    {

        if (GetFibonacciNumber(Position)== -1) 
        {

            Debug.Log("Introduce un valor mayor a 0.");
        
        }

        else
        {
            Debug.Log("La posición " + Position + " corresponde al valor " + GetFibonacciNumber(Position));


        }
      


    }

    private int GetFibonacciNumber(int position)
    {
        int numberOne = 0,
            numberTwo = 1,
            addition = 0;

        if (position > 0)
        {
            //Bucle que indica que si la posición es mayor que 0 recorrerá la escala de Fibonacci
            for(int i = 0; i < position; i++)
            {
                addition = numberOne + numberTwo;
                numberOne = numberTwo;
                numberTwo = addition;

            }

            //Retorna el último cáculo si está fuera del bucle, si estuviera dentro retornaría el resultado de la suma
            return addition;

        }

        
        
        
        return -1;



    }


}
