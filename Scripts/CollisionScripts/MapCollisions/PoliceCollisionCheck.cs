using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoliceCollisionCheck : MonoBehaviour
{

    String verifyName = "Police_Station";

    public bool rightCol = false;
    
    // Start is called before the first frame update
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

    void OnCollisionStay(Collision objectName) {
        // Debug.Log("Colliding");
    }

    void OnCollisionExit(Collision objectName) {

        rightCol = false;
        // Debug.Log("Gone");
    }
}
