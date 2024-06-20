using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour
{
    int global;

    // Start is called before the first frame update
    void Start()
    {
        //Calling Function
        //Add();
        Debug.Log(Add(2,5));
    }

    // Update is called once per frame
    void Update()
    {
        //Add();
    }
    //customize function
    /*public void Add()
    {
        Debug.Log("This is a Add function");
    }*/
    public int Add(int num1,int num2)
    {
        //result is a local variabl
        int result = num1 + num2;
        return result;
        //Debug.Log(global);
    }
}
