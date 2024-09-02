using System.Collections;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Timer : MonoBehaviour
{

    public float timeRemaining;
    public bool timerIsRunning = false;

    public Text timeText;
    public string sceneName;

    void Start() {
        // Initialse timer to running
        timerIsRunning = true;
    }


    void Update() {

        // If there's still time left
        if (timeRemaining > 0) {
            // Countdown time
            timeRemaining -= Time.deltaTime;
            DisplayTime(timeRemaining);
        }
        else {
            // Load scene once timer done
            SceneManager.LoadScene(sceneName);

            Debug.Log("Time has run out!");
            timeRemaining = 0;
            timerIsRunning = false;
        }
    }

    void DisplayTime(float timeToDisplay) {
        // Only to make timer familiar
        timeToDisplay += 1;

        // Calculate minutes and seconds in friendly manner
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
} 