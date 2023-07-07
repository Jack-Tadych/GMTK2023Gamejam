using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public List<Item> inventoryItems = new List<Item>();

    public void AddItem(Item item)
    {
        inventoryItems.Add(item);
        Debug.Log("Item added to inventory: " + item.name);
    }

    public void RemoveItem(Item item)
    {
        inventoryItems.Remove(item);
        Debug.Log("Item removed from inventory: " + item.name);
    }
    
    public bool HasItem(string itemToCheck)
    {
        
        foreach (Item item in inventoryItems)
        {
            if(item != null){
                print(item.GetItemName());
                if (itemToCheck == item.GetItemName())
                {
                    RemoveItem(item);
                    return true;
                }
            
                
            }
        
        
        }
        return false;
    }

    
}
