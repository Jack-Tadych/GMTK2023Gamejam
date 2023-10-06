using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class Interactscript : MonoBehaviour

{
   public float maxDistance = 5f; 
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
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit, maxDistance))
            {
                if (hit.collider.CompareTag("Intractable"))
                {
                    string objectName = hit.collider.gameObject.name;
                    Debug.Log("Interacted with: " + objectName);
                      dialogueRunner.StartDialogue(objectName);
                } 
            }           
        }
    }
}
