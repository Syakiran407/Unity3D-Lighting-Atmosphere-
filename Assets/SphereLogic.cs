using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereLogic : MonoBehaviour
{

    int m_framecounter = 0;


    // Start is called before the first frame update
    void Start() //void start is executed once the game starts before the first frame update
    {
        Debug.Log("Hello World, this is a sphere"); //Print debug message on Console
    }

    // Update is called once per frame
    void Update() //Is called once per frame because when the game runs 60 fps per second, this function will called 60 times per second
    {
        ++m_framecounter; 

        Debug.Log("Number of frames passed: " + m_framecounter);
    }
}
