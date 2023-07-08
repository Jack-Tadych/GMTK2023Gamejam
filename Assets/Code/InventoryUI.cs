using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUI : MonoBehaviour
{
    private GameObject inventoryPanel;
    private Text inventoryText;
    private GameManager gameManager;
    private GameObject canvasObject; // Reference to the Canvas object in the scene

    private void Start()
    {
        canvasObject = GameObject.Find("Canvas");

        if (canvasObject != null)
        {
            // Find the InventoryPanel child object
            inventoryPanel = canvasObject.transform.Find("InventoryPanel").gameObject;

            if (inventoryPanel != null)
            {
                // Find the Text component of the InventoryPanel
                inventoryText = inventoryPanel.GetComponentInChildren<Text>();

                if (inventoryText != null)
                {
                    // Change the text of the InventoryPanel
                    Debug.Log("inventoryText found");
                }
                else
                {
                    Debug.LogError("Text component not found in InventoryPanel!");
                }
            }
            else
            {
                Debug.LogError("InventoryPanel object not found!");
            }
        }
        else
        {
            Debug.LogError("Canvas object not found!");
        }
        
        inventoryPanel.SetActive(false);
        gameManager = FindObjectOfType<GameManager>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            bool isOpen = !inventoryPanel.activeSelf;
            inventoryPanel.SetActive(isOpen);

            if (isOpen)
            {
                DisplayInventory();
            }
        }
    }

    private void DisplayInventory()
    {
        string inventoryContent = "Inventory:\n";

        foreach (Item item in gameManager.inventoryItems)
        {
            inventoryContent += "- " + item.GetItemName() + "\n";
        }

        inventoryText.text = inventoryContent;
    }
}
