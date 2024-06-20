using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class If_Statement : MonoBehaviour
{
    //if the age is greater than 18
    //person can vote
    public int age;
    // Start is called before the first frame update
    void Start()
    {
        if (age > 18)
        {
            Debug.Log("You can Vote");
        }
        else
        {
            Debug.Log("You cannot Vote");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
