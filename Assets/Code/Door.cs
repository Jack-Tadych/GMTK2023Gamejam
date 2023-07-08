using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public Material targetMaterial;
    [Range(0f, 1f)]
    public float transparency = 1f;

    private bool isPlayerInsideTrigger = false;
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (isPlayerInsideTrigger)
        {
            // Trigger the animation
            animator.SetTrigger("TriggerAnimation");
        }

        targetMaterial.SetFloat("_Alpha", transparency);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInsideTrigger = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInsideTrigger = false;
        }
    }
}