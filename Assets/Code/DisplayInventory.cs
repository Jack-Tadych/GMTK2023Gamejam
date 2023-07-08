using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayInventory : MonoBehaviour
{
    private GameManager GameManager;

    private void Start()
    {
        GameManager = GetComponent<GameManager>();
        PrintInventoryItems();
    }

    private void PrintInventoryItems()
    {
        foreach (Item item in GameManager.inventoryItems)
        {
            Debug.Log("Item in inventory: " + item.GetItemName());
        }
    }
}
