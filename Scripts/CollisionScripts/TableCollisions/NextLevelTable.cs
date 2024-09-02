using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelTable : MonoBehaviour {
    public String sceneName;
    public GameObject door;
    public TableLightCorrection roomLight;

    

    // Start is called before the first frame update
    void Start() {
        // Hide door initially
        door.GetComponent<Renderer>().enabled = false;
    }

    // Update is called once per frame
    void Update() {
        // If the green light is given
        if (roomLight.ontoNextLevel) {
            // Show door
            door.GetComponent<Renderer>().enabled = true;
        }
    }

    void OnCollisionEnter(Collision objectName) {
        // If collision and allowed onto next level
        if (roomLight.ontoNextLevel) {
            if (objectName.gameObject.name == "Human") {
                SceneManager.LoadScene(sceneName);
            }
            
        }
    }
}
