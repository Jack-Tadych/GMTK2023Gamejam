using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private InventoryManager inventoryManager;
    private string inventoryFilePath = "inventory.txt";

    private void Start()
    {
        inventoryManager = FindObjectOfType<InventoryManager>();

        // Add some sample items to the inventory
        // Save the inventory at the start of the game
       

        // Populate the inventory from the saved file
        
    }
    
    private void Update()
    {
        // Get the inventory items and print their names
        List<Item> inventoryItems = inventoryManager.GetInventoryItems();
        foreach (Item item in inventoryItems)
        {
            Debug.Log("Item Name: " + item.GetItemName());
        }
    }
}
