    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class Interactscript : MonoBehaviour
{
    public float maxDistance = 5f;
    public float sphereRadius = 2f; // Set the radius of the sphere cast
    private DialogueRunner dialogueRunner;
    private void Start()
    {
        dialogueRunner = FindObjectOfType<DialogueRunner>();
    }

    private void Update()
    {
        interact();
    }
   


    private void interact()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            RaycastHit[] hits = Physics.SphereCastAll(transform.position, sphereRadius, transform.forward, maxDistance);

            foreach (RaycastHit hit in hits)
            {
                if (hit.collider.CompareTag("Intractable"))
                {
                    
                    string objectName = hit.collider.gameObject.name;
                    Debug.Log("Interacted with: " + objectName);
                    dialogueRunner.StartDialogue(objectName);
                    break; // Exit loop after the first interactable object is found
                } else if (hit.collider.CompareTag("Item"))
                {
                    GameObject collided = hit.collider.gameObject;
                    string objectName = collided.name;
                    Debug.Log("Interacted with: " + objectName);
                    dialogueRunner.StartDialogue(objectName);
                    collided.SetActive(false); //removes object from sceen
                    break; // Exit loop after the first interactable object is found
                }
            }
        }
    }

  
}

 