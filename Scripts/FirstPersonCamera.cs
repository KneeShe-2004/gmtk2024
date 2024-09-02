using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// With help from https://www.youtube.com/watch?v=5Rq8A4H6Nzw
// public class FirstPersonCamera : MonoBehaviour
// {
//     // Variables
//     public Transform player;
//     public float mouseSens = 2f;
//     float cameraVerticalRotation = 0f;
//     float cameraHorizontalRotation = 0f;
//     bool lockedCursor = true;



//     // Start is called before the first frame update
//     void Start()
//     {
//         // Lock cursor
//         Cursor.lockState = CursorLockMode.Locked;
//     }

//     // Update is called once per frame
//     void Update()
//     {
        
//         Cursor.visible = true;

//         // Collect mouse input
//         float inputX = Input.GetAxis("Mouse X") * mouseSens;
//         float inputY = Input.GetAxis("Mouse Y") * mouseSens;

//         // Rotate around x-axis
//         cameraVerticalRotation -= inputY;
//         cameraVerticalRotation = Mathf.Clamp(cameraVerticalRotation, -90f, 90f);

//         cameraHorizontalRotation -= inputX;
//         cameraVerticalRotation = Mathf.Clamp(cameraVerticalRotation, -90f, 90f);
       

//         transform.localEulerAngles = (Vector3.right * cameraVerticalRotation) + (Vector3.up * cameraHorizontalRotation);

    

//         // Rotate player and camera around Y
//         // player.Rotate(Vector3.up * inputX);

//         // transform.position = player.position;
//     }

//     void LateUpdate() {
//         // transform.position = player.position;

//     }
// }

public class FirstPersonCamera : MonoBehaviour {
    public float sensX;
    public float sensY;

    public Transform orientation;
    float xRotation;
    float yRotation;

    private void Start() {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = true;
    }

    private void Update() {
        Cursor.visible = true;
        
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;

        yRotation += mouseX;
        xRotation -= mouseY;

        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        orientation.rotation = Quaternion.Euler(0, yRotation, 0);
    }
}
