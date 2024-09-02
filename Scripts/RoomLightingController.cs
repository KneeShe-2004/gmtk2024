using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomLightingController : MonoBehaviour
{
    public Light redLight;
    public Light greenLight;
    public AllCorrectCheck allCorrect;

    public bool ontoNextLevel = false;

    // Start is called before the first frame update
    void Start() {
        // Sets initial light to red
        redLight.intensity = 1.5f; 
        greenLight.intensity = 0f;
     
    }

    // Update is called once per frame
    void Update() {
        if (allCorrect.allcorrect) {
            // If everything is in place, change light to green
            Debug.Log("Here");
            redLight.intensity = 0;
            greenLight.intensity = 1.5f;
            ontoNextLevel = true;
        }
    }
}
