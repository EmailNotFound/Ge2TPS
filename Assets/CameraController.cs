using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float mouseSensitivity = 100f;
    public Transform playerBody;

    private float xRotation = 0f;

    void Start()
    {
        // Optionally, hide the cursor when the game starts
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f); // Prevents the camera from over-rotating

        // Apply the rotation to the camera (for looking up and down)
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        // Apply the rotation to the player body (for turning left and right)
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
