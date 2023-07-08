using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUI : MonoBehaviour
{
    public GameObject uiElement;
    private Animator animator;
    private InventoryManager inventoryManager;
    public Text inventoryText;

    private void Start()
    {
        uiElement.SetActive(false);
        animator = uiElement.GetComponent<Animator>();
        inventoryManager = FindObjectOfType<InventoryManager>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            bool isOpen = !uiElement.activeSelf;
            uiElement.SetActive(isOpen);

            if (animator != null)
            {
                animator.SetBool("IsOpen", isOpen);
            }

            if (isOpen)
            {
                DisplayInventory();
            }
        }
    }

    private void DisplayInventory()
    {
        string inventoryContent = "Inventory:\n";

        foreach (Item item in inventoryManager.inventoryItems)
        {
            inventoryContent += "- " + item.GetItemName() + "\n";
        }

        inventoryText.text = inventoryContent;
    }
}
