using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUI : MonoBehaviour
{
    public Image inventoryIcon;

    private void Start()
    {
        // InventoryManager inventoryManager = FindObjectOfType<InventoryManager>();
        // inventoryManager.AddItemEvent += UpdateInventoryUI;
    }

    private void UpdateInventoryUI(Item newItem)
    {
        inventoryIcon.sprite = newItem.itemIcon;
    }
}
