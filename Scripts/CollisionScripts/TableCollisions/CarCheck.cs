using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarCheck : MonoBehaviour
{
    // Start is called before the first frame update
    String verifyName = "Vehicle_SUV_color03";

    public bool rightCol = false;

    void OnCollisionEnter(Collision collision) {

        Debug.Log("Collided");

        if (collision.gameObject.name == verifyName) {
            Debug.Log("Right collision");
            rightCol = true;
        }
        else {
            rightCol = false;
            Debug.Log("Wrong collision");
        }
        
    }

     void OnCollisionExit(Collision objectName) {

        rightCol = false;
        // Debug.Log("Gone");
    }

}
