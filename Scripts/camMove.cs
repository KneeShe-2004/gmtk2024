using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camMove : MonoBehaviour
{
    public Transform cameraPosition;

    // Update is called once per frame
    private void Update() {
        transform.position = cameraPosition.position;
    }
}
