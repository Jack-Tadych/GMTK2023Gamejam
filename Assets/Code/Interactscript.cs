using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactscript : MonoBehaviour

{
   public string  objectInfo;
   public Sprite objectsprit;
   public float maxDistance = 5f; // Maximum distance allowed for picking up the item
   private void Update()
    {
        interact();
    }

    private void interact()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            GameObject playerObject = GameObject.FindWithTag("Player");
            if (playerObject != null)
            {
                Vector3 playerPosition = playerObject.transform.position;
                // Check if the player is within the maximum distance
                float distance = Vector3.Distance(transform.position, playerPosition);
                if (distance <= maxDistance)
                {
                    GameManager GameManager = FindObjectOfType<GameManager>();
                    GameManager.ChangePopupTextToSomethingElse(objectInfo, objectsprit);
                }
            }
        }
    }
}
