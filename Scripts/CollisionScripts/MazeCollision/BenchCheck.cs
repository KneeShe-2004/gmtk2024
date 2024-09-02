using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BenchCheck : MonoBehaviour
{
    // Start is called before the first frame update
    String verifyName = "Props_Bench_1";

    public bool rightCol = false;

    void OnCollisionEnter(Collision collision) {

        Debug.Log("Collided");

        if (collision.gameObject.name == verifyName) {
            Debug.Log("Right collision");
            rightCol = true;
            Debug.Log("RighCol value" + rightCol);
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
