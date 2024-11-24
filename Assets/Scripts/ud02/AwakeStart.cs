using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwakeStart : MonoBehaviour
{
    //Awake es como un pre-frame
    private void Awake()
    {

        Debug.Log("Soy el Awake y me ejecuto en primer lugar: " + Time.deltaTime);

    }


    // Start is called before the first frame update
    void Start()
    {

        Debug.Log("Soy el Start y me ejecuto en segundo lugar: " + Time.deltaTime);

    }

    // Update is called once per frame
    void Update()
    {

        Debug.Log("Soy el Update y me ejecuto en cuarto lugar: " + Time.deltaTime);

    }

    private void FixedUpdate()
    {
        Debug.Log("Soy el FixedUpdate y me ejecuto en tercer lugar: " + Time.deltaTime);

    }

}
