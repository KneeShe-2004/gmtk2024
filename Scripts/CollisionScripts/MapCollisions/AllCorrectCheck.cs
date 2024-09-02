using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllCorrectCheck : MonoBehaviour
{
    // Start is called before the first frame update

    public bool allcorrect;
    public MarketCollisionCheck market;
    public PoliceCollisionCheck police;
    public SchoolCollisionCheck school;
    public WorkshopCollisionCheck workshop;

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        // Checks if all the spaces are right
        if(market.rightCol && police.rightCol && school.rightCol && workshop.rightCol) {
            allcorrect = true;
            Debug.Log("All right!");
        }
        
    }
}
