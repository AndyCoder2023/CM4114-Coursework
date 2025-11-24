using UnityEngine;

public class rotateTowardsCamera : MonoBehaviour
{
    private Camera mainCamera;

    void Start()
    {
        mainCamera = Camera.main;
    }

    void Update()
    {
        if (mainCamera != null)
        {
            // Target the camera's position
            transform.LookAt(mainCamera.transform.position);
        }
    }
}
