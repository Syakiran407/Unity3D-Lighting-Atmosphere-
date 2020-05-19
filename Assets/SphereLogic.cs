using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereLogic : MonoBehaviour
{


    Rigidbody m_rigidbody; //Access the rigidbody

    // Start is called before the first frame update
    void Start() //void start is executed once the game starts before the first frame update
    {
        m_rigidbody = GetComponent<Rigidbody>(); //Search all of the components of an object type RigidBody and store in the variable
    }

    // Update is called once per frame
    void Update() //Is called once per frame because when the game runs 60 fps per second, this function will called 60 times per second
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            m_rigidbody.AddForce(new Vector3(0, 1000, 0));
        }
    }
}
