using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public List<Item> inventoryItems = new List<Item>();

    public void AddItem(Item item)
    {
        inventoryItems.Add(item);
        //Debug.Log("Item added to inventory: " + item.name);
        randomShit();
    }

    public void RemoveItem(Item item)
    {
        inventoryItems.Remove(item);
        //Debug.Log("Item removed from inventory: " + item.name);
    }

    public bool HasItem(string itemToCheck){
        foreach (Item item in inventoryItems)
        {
            if (item != null)
            {
                if (itemToCheck == item.GetItemName())
                {
                    RemoveItem(item);
                    return true;
                }
            }
        }
        return false;
    }

    public List<Item> GetInventoryItems() {
        return inventoryItems;
    }

    public void SaveInventory(string filePath)
    {
        string[] lines = new string[inventoryItems.Count];
        for (int i = 0; i < inventoryItems.Count; i++)
        {
            lines[i] = inventoryItems[i].GetItemName();
        }
        File.WriteAllLines(filePath, lines);
        Debug.Log("Inventory saved to file: " + filePath);
    }

    public void PopulateInventory(string filePath)
    {
        if (File.Exists(filePath))
        {
            string[] lines = File.ReadAllLines(filePath);
            inventoryItems.Clear();
            for (int i = 0; i < lines.Length; i++)
            {
                string itemName = lines[i];
                // Create new item object based on the name and add it to the inventory
                Item newItem = new Item(itemName);
                inventoryItems.Add(newItem);
            }
            Debug.Log("Inventory populated from file: " + filePath);
        }
        else
        {
            Debug.Log("Inventory file not found: " + filePath);
        }
    }

    private void randomShit()
    {
        // Placeholder method
    }
}
