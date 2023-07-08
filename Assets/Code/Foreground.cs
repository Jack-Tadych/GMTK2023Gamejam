using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Foreground : MonoBehaviour
{
    public Material targetMaterial;
    [Range(0f, 1f)]
    public float transparency = 1f;

    private bool isPlayerInsideTrigger = false;
    private Renderer renderer;
    private bool isWallOpen = false;
    private Animator anim;


    private void Start()
    {
        renderer = GetComponent<Renderer>();
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        Color color = targetMaterial.color;
        color.a = transparency;
        targetMaterial.color = color;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInsideTrigger = true;
            Debug.Log("Going through!");
            ToggleWall();
        }
    }

    void ToggleWall()
    {
        Debug.Log("Toggling the wall!");
        isWallOpen = !isWallOpen;
        anim.SetBool("Door", isWallOpen);
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInsideTrigger = false;
            Debug.Log("Going Through!");
            ToggleWall();
        }
    }
}