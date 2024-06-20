using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables_DataTypes : MonoBehaviour
{
    int myInt = 5;
    float myFloat = 10.5f;
    bool mybool = true;
    public string mystring;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("The value of myInt is: " + myInt);
                    Debug.Log("The value of myFloat is: " + myFloat);

                    Debug.Log("The value of mybool is: " + mybool);
        Debug.Log("The name is: " + mystring);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
