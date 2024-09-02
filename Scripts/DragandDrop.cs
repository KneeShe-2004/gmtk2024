using System.Collections;
using UnityEngine;

class DragTransform : MonoBehaviour
{
    public Camera camera;
    private bool dragging = false;
    private float distance;

    public Rigidbody rb;

    void OnMouseDown()
    {
        // Gets the distance from mouse to camera
        distance = Vector3.Distance(transform.position, camera.transform.position);
        dragging = true;
    }

    void OnMouseUp()
    {
        // Resets dragging
        dragging = false;
    }

    void Update()
    {
        // Gravity when item not being dragged

        rb.useGravity = true;
        if (dragging) {
            rb.useGravity = false;
            // Ray cast to item
            Ray ray =camera.ScreenPointToRay(Input.mousePosition);

            // Transform position of item every frame
            Vector3 rayPoint = ray.GetPoint(distance);
            transform.position = rayPoint;
        }
    }
}