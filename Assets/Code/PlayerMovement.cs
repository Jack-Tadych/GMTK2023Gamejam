using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;  // Movement speed

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        // Get input from horizontal and vertical axes
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Calculate movement direction
        Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical);

        // Apply movement
        rb.velocity = movement * speed;
    }
}
