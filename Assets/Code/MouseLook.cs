using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float sensitivity = 100f;  // Mouse sensitivity

    private float xRotation = 0f;
    private Transform playerTransform;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;  // Lock cursor to the center of the screen
        playerTransform = transform.parent;  // Assuming the camera is a child of the player object
    }

    private void Update()
    {
        // Get mouse input
        float mouseX = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

        // Rotate player horizontally
        playerTransform.Rotate(Vector3.up * mouseX);

        // Rotate camera vertically
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);  // Limit vertical rotation between -90 and 90 degrees
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
    }
}
