using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayInventory : MonoBehaviour
{
    private InventoryManager inventoryManager;

    private void Start()
    {
        inventoryManager = GetComponent<InventoryManager>();
        PrintInventoryItems();
    }

    private void PrintInventoryItems()
    {
        foreach (Item item in inventoryManager.inventoryItems)
        {
            Debug.Log("Item in inventory: " + item.GetItemName());
        }
    }
}
