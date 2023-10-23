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
                    GameObject test = hit.collider.gameObject;
                    deactivate(test);
                    break; // Exit loop after the first interactable object is found
                }
            }
        }
    }
    
   
    public static void deactivate(GameObject test){
        test.SetActive(false);
    }
}

 