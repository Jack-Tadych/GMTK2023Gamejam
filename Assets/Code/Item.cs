using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    public string itemName;
    public float maxDistance = 5f; // Maximum distance allowed for picking up the item
    public string  Itemdescription;
    public Sprite something = null;
    private void Update()
    {
        PickupItem();
    }

    private void PickupItem()
    {
        if (Input.GetKeyDown(KeyCode.R))
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
                    GameManager.AddItem(this);
                    gameObject.SetActive(false);
                    //Destroy(gameObject);
                }
            }
        }
    }
    public Item(string name)
    {
        itemName = name;
    }
    public Item(string name, string description ){
        itemName = name;
        Itemdescription = description;
    }
    public string GetItemName()
    {
        return itemName;
    }

  
}
