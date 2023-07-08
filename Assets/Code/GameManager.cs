using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
public class GameManager : MonoBehaviour
{   
    //lists
    private List<Choice> choiceList = new List<Choice>();
    public List<Item> inventoryItems = new List<Item>();
    //audios
    public AudioClip addItemSound;
    public AudioClip removeItemSound;
    //player location and canves
    public Transform spawnPoint;
    public GameObject playerPrefab;
    public GameObject canvasPrefab;
    public CinemachineVirtualCamera camera;
    private GameObject playerObject;

    private void Start(){
        AddPlayerAndCanvas();
        LookAtPlayer();
    }
    
    private void Update(){
    }
    
    public void LookAtPlayer(){
    if (camera != null)
    {
        camera.Follow = playerObject.transform;
        camera.LookAt = playerObject.transform;
    }
    else
    {
        Debug.LogError("CinemachineVirtualCamera is null!");
    }
}

    public void AddPlayerAndCanvas(){
        // Instantiate the player prefab
        GameObject playerObject = Instantiate(playerPrefab, spawnPoint.position, spawnPoint.rotation);


        // Instantiate the canvas prefab
        GameObject canvas = Instantiate(canvasPrefab);

        // Additional setup and logic for the player and canvas prefabs
        // For example, you might position them in the scene, assign references, etc.
    }


    //inventory methods 
    public void AddItem(Item item){
        inventoryItems.Add(item);
        SpawnAudioSource(addItemSound);
        // Additional logic for managing items in the game
    }

    public void RemoveItem(Item item){
        inventoryItems.Remove(item);
        SpawnAudioSource(removeItemSound);
        // Additional logic for managing items in the game
    }

    //sound
    public void SpawnAudioSource(AudioClip clip){
        // Create a new game object to hold the AudioSource
        GameObject audioObject = new GameObject("AudioSource");

        // Attach an AudioSource component to the new game object
        AudioSource audioSource = audioObject.AddComponent<AudioSource>();

        // Set the clip to play on the AudioSource
        audioSource.clip = clip;

        // Play the clip
        audioSource.Play();

        // Destroy the audioObject after the clip has finished playing
        Destroy(audioObject, clip.length);
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
