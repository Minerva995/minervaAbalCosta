using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //Dibujo de linea que indica la unión entre un punto y otro punto

        Vector2 myCenter = new Vector2(0.0f, 0.0f);
        //Vector2 myPoint = new Vector2(3.0f, 2.0f);

        //Similar a lo anterior pero ahora detecta el cursor del raton

        Vector2 myMouse = Input.mousePosition;
        Debug.DrawLine(myCenter, myMouse, Color.yellow);

    }
}
