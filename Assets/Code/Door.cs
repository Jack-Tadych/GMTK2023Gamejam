using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
<<<<<<< HEAD
    public Material targetMaterial;
    [Range(0f, 1f)]
    public float transparency = 1f;
=======
    private Animator doorAnimator;
    private bool isDoorOpen = false;
    private bool isDoorInteractable = false; //Determined by player in range or not
<<<<<<< HEAD
    public string sceneToLoad;
>>>>>>> master
=======
>>>>>>> master

    private bool isPlayerInsideTrigger = false;
    private Animator animator;

    private void Start()
    {
<<<<<<< HEAD
        animator = GetComponent<Animator>();
=======
        if (other.gameObject.tag == "Player")
        {
            //get into the interactible range
            isDoorInteractable = true;
            Debug.Log("Close enough! Press E key to open/close the door");
            ToggleDoor();
        }
    }
    //Update is executed on every frame. Think of it as always doing
    
    //ToggleDoor: Toggle the isDoorOpen flag and inform the animator the new state
    void ToggleDoor() {
        Debug.Log("Toggling the door!");
        isDoorOpen = !isDoorOpen;
        doorAnimator.SetBool("IsOpen", isDoorOpen);
>>>>>>> master
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