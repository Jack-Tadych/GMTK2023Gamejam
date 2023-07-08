using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUI : MonoBehaviour
{
    private GameObject inventoryPanel;
    private Text inventoryText;
    //private Animator animator;
    private GameManager gameManager;
    private GameObject canvasObject; // Reference to the Canvas object in the scene
    
    private void Start()
    {
        //animator = inventoryPanel.GetComponent<Animator>();
        gameManager = FindObjectOfType<GameManager>();
        canvasObject = GameObject.Find("Canvas");

        if (canvasObject != null){
            // Find the Popup Notification child object
            inventoryPanel = canvasObject.transform.Find("InventoryPanel").gameObject;

            if (inventoryPanel != null){
                // Find the Text component of the Popup Notification
                inventoryText = inventoryPanel.GetComponentInChildren<Text>();

                if (inventoryText != null){
                    // Change the text of the Popup Notification
                    Debug.Log("inventoryText found");
                }
                else{
                    Debug.LogError("Text component not found in Popup Notification!");
                }
            }
            else{
                Debug.LogError("Popup Notification object not found!");
            }
        }
        else{
            Debug.LogError("Canvas object not found!");
        }
        inventoryPanel.SetActive(false);
    }   

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            bool isOpen = !inventoryPanel.activeSelf;
            inventoryPanel.SetActive(isOpen);

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

        foreach (Item item in gameManager.inventoryItems)
        {
            inventoryContent += "- " + item.GetItemName() + "\n";
        }

        inventoryText.text = inventoryContent;
    }
}
