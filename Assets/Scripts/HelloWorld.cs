using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{

    //Zona de variables globales
    public int IntegerNumber = -35;
    public float StudentGrade = 8.5f; //8.0f
    public string StudentName = "Alarico";
    public bool IsAnActiveStudent = true;
    public char Password = '*';
    public long BigNumer = 12345;
    public double BigStudentGrade = 8.55d;
    public byte LittleNumber = 255;
    public byte ExampleAdd = 134;

    // Start is called before the first frame update
    void Start() // esto es un metodo
    {

        StudentGrade = 5 + (8 - ((9 * 8) / 7));
        LittleNumber = 2 % 1; //LittleNumber = 0; // esto es un operador de modulo;
        LittleNumber = 3 % 2; // LittleNumer = 1;


        //Imprimir en la Consola --concatenacion
        //Debug.Log("El resultado de la operación de módulo es: " + LittleNumber);
        Debug.Log(LittleNumber + "849923");
        Debug.Log("El número más \"pequeño\" del mundo \n es: " + LittleNumber);


    }

    // Update is called once per frame
    void Update()
    {

        //StudentGrade = StudentGrade + 1; // StudentGrade ++; // StudentGrade +=1;
        StudentGrade--;

        LittleNumber = 254;
        Debug.Log(LittleNumber);
    }
}
