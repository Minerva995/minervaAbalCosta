using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StructsValue : MonoBehaviour
{

    //Zona de variables globales

    //Constructor, para conseguir un color que no se encuentra en la lista, se busca los valores rgb del color, y se divide cada valor entre 256, el cuarto valor indica el Alpha

    public Color myColor = new Color(0.562f, 0.687f, 0.511f, 0.5f);

    // Con Color32 no es necesario dividir los valores, pueden escribirse tal cual, el cuarto valor indica el Alpha

    public Color32 MyTrueColor = new Color(255, 165, 0, 0.5f);


    public Vector2 MyVector2 = new Vector2(1.5f, 2.5f);
    public Vector3 MyVector3 = new Vector3(1.5f, 2.5f, 3.5f);
    public Quaternion MyQuaternion = Quaternion.identity;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
