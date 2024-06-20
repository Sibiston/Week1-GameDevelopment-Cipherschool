using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        /* for(int i=0; i <=10; i++)
         {
             Debug.Log("Value of i is: " + i);
         }*/
        int i = 0;
        //while i<=10
        //debug the value of i in console
        /*while (i <=10)
        {
            Debug.Log("Value of i is: " + i);
            i++;
        }*/

        do
        {
            Debug.Log("i is : " + i);
            i++;

        }
        while (i <= 10);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
