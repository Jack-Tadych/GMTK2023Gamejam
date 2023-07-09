using UnityEngine;

public class animationJack : MonoBehaviour
{
    public Animator animator;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Vector3 velocity = rb.velocity;

        // Check if the object is moving
        if (velocity.magnitude > 0)
        {
            // Trigger move animation
            animator.SetBool("IsMoving", true);
        }
        else
        {
            // Stop move animation
            animator.SetBool("IsMoving", false);
        }
    }
}