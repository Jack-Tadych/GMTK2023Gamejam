using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<Choice> choiceList = new List<Choice>();
    public List<Item> inventoryItems = new List<Item>();
    public AudioSource audioSource;
    public AudioClip addItemSound;
    public AudioClip removeItemSound;
    
    private void Start()
    {
       
        
    }
    
    private void Update(){
    }
    

    //inventory methods 
    public void AddItem(Item item){
        inventoryItems.Add(item);
        PlaySound(addItemSound);
        // Additional logic for managing items in the game
    }

    public void RemoveItem(Item item){
        inventoryItems.Remove(item);
        PlaySound(removeItemSound);
        // Additional logic for managing items in the game
    }

    //sound
    private void PlaySound(AudioClip sound){
        if (audioSource != null && sound != null)
        {
            audioSource.PlayOneShot(sound);
        }
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

    //choice methods 
    public void PrintChoiceList(){
        foreach (Choice choice in choiceList)
        {
          ChangePopupTextToSomethingElse(choice.GetDescription());
        }
    }  
    
    public bool addChoiceToList(Choice newChoice){
        choiceList.Add(newChoice);
        PrintChoiceList();
        return true;
    }


    //text changer
    public void ChangePopupTextToSomethingElse(string text){
        PopupNotification popupNotificationScript = FindObjectOfType<PopupNotification>();

        if (popupNotificationScript != null)
        {
            popupNotificationScript.setPopupText(text);
        }
        else
        {
            Debug.LogError("PopupNotification script not found!");
        }
    }

}
