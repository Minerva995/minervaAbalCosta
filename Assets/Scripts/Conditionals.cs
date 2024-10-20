using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class Conditionals : MonoBehaviour
{

    //Zona de variables globales
    public int NumberOne;
    public int NumberTwo;
    public char Letter;
    public int DayNumber;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        IsPositive();
        IsOdd();
        IsAscendingNumber();
        IsVowel();
        IsDayWeek();

    }


    private void IsPositive()
    {
        if(NumberOne >=0)
        {
            Debug.Log(NumberOne + " es positivo");


        }

        else
        {
            Debug.Log(NumberOne + " es negativo");

        }

    }




    private void IsOdd()
    {

       if (NumberOne % 2 == 0)
        {
            Debug.Log(NumberOne + " es par");

        }

        else
        {
            Debug.Log(NumberOne + " es impar");

        }

    }




    private void IsAscendingNumber()
    {
        if (NumberOne < NumberTwo)
        {
            Debug.Log("El orden ascendente de los números es: " + NumberOne + "\t" + NumberTwo);

        }


        else if (NumberOne == NumberTwo)
        {

            Debug.Log("Los dos números son iguales.");

        }

        else
        {
            Debug.Log("El orden ascendente de los números es: " + NumberTwo + "\t" + NumberOne);

        }
    }



    private void IsVowel()
    {
        if (Letter == 'a' || Letter == 'e' || Letter == 'i' || Letter == 'o' || Letter == 'u')
        {

            Debug.Log(Letter + " es una vocal.");
        
        
        }

        else
        {

            Debug.Log(Letter + " no es una vocal.");

        }

    }



    private void IsDayWeek()
    {

        switch (DayNumber)
        {

            case 1:
                Debug.Log("Lunes");
                break;

            case 2:
                Debug.Log("Martes");
                break;

            case 3:
                Debug.Log("Miércoles");
                break;

            case 4:
                Debug.Log("Jueves");
                break;

            case 5:
                Debug.Log("Viernes");
                break;

            case 6:
                Debug.Log("Sábado");
                break;

            case 7:
                Debug.Log("Domingo");
                break;

            default:
                Debug.Log("El número introducido no se corresponde con ningún día de la semana.");
                break;


        }


    }





}
