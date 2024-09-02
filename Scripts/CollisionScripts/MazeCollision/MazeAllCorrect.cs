using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeAllCorrect : MonoBehaviour
{
    // Start is called before the first frame update

    public bool allcorrect;
    public TrafficCheck traffic;
    public CoffeeCheck coffee;
    public FenceCheck fence;
    public BarrierCheck barrier;
    public BenchCheck bench;
    public BinCheck bin;
    public HydrantCheck hydrant;

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        // Checks if all the spaces are right
        if(traffic.rightCol && coffee.rightCol && fence.rightCol && barrier.rightCol && bench.rightCol && bin.rightCol && hydrant.rightCol) {
            allcorrect = true;
            Debug.Log("All right!");
        }
        
    }
}
