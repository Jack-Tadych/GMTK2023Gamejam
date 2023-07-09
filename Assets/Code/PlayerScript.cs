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

        // Mirror the animation if moving on the X axis
        if (isMoving && Mathf.Abs(moveHorizontal) > 0.1f)
        {
            if (moveHorizontal > 0f && !facingRight)
            {
                Flip();
            }
            else if (moveHorizontal < 0f && facingRight)
            {
                Flip();
            }
        }
    }

    private void Flip()
    {
        // Toggle the facing direction
        facingRight = !facingRight;

        // Get the current scale
        Vector3 scale = transform.localScale;

        // Flip the scale on the X axis to mirror the animation
        scale.x *= -1;

        // Apply the updated scale
        transform.localScale = scale;
    }
}
