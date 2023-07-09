using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody rb;
    private Animator anim;
    public SpriteRenderer sr;
    private bool facingRight = true;
    private bool hasFlipped = false;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical);

        rb.velocity = movement * speed;

        // Check if the player is moving
        bool isMoving = rb.velocity.magnitude > 0.1f;

        // Trigger the move animation based on the movement
        anim.SetBool("IsMoving", isMoving);

    }
}
