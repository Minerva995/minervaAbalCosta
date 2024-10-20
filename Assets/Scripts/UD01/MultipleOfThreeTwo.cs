using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultipleOfThreeTwo : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i <= 100; i++)
        {
            if (i % 2 == 0 && i % 3 == 0)
            {
                Debug.Log(i);
            }
        }
    }

}
