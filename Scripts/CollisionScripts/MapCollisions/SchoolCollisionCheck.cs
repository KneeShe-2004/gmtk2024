using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SchoolCollisionCheck : MonoBehaviour
{

    String verifyName = "School";

    public bool rightCol = false;
    
    // Start is called before the first frame update
    void OnCollisionEnter(Collision objectName) {


        if (objectName.gameObject.name == verifyName) {
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
        Debug.Log("Gone");
    }
}
