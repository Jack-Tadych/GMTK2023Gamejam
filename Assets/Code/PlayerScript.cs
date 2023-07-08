using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    private Rigidbody rb;
    public float speed = 5f;

    public Animator anim;
    private Vector2 moveInput;
    public SpriteRenderer sr;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        moveInput = new Vector2(moveHorizontal, moveVertical);

        Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical);

        rb.velocity = movement * speed;

        if(!sr.flipX && moveInput.x < 0)
        {
            StartCoroutine(FlipWithDelay(true));
        }
        else if (sr.flipX && moveInput.x > 0)
        {
            StartCoroutine(FlipWithDelay(false));
        }
    }

    private IEnumerator FlipWithDelay(bool flipValue)
    {
        anim.SetTrigger("Flip");
        yield return new WaitForSeconds(anim.GetCurrentAnimatorClipInfo(0)[0].clip.length);
        sr.flipX = flipValue;
    }
}