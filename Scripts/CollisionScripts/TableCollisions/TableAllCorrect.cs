using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableAllCorrect : MonoBehaviour
{
    // Start is called before the first frame update

    public bool allcorrect;
    public RedCheck red;

    public BlueCheck blue;
    public YellowCheck yellow;
    public TruckCheck truck;
    public CarCheck car;


    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        // Checks if all the spaces are right
        if(red.rightCol && blue.rightCol && yellow.rightCol && truck.rightCol && car.rightCol) {
            allcorrect = true;
            Debug.Log("All right!");
        }
        
    }
}
