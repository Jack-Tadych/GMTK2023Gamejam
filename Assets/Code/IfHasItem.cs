using UnityEngine;

public class IfHasItem : MonoBehaviour
{
    public string itemToCheck = ""; // The item name to check in the inventory
    public GameObject objectToSpawn;
    public float maxDistance = 2f; // Maximum distance allowed for picking up the item
    public float y = 0f; // Default value for the y position
    public Quaternion rotation = Quaternion.identity; // Default rotation
    public string ChoiceName = "";
    public string description = "";
    public Sprite spriteChoice;
    private void OnMouseDown(){
       

        GameManager GameManager = FindObjectOfType<GameManager>();
        
        // Check if the specified item is in the inventory
        GameObject playerObject = GameObject.FindWithTag("Player");
        if (playerObject != null)
        {
            Vector3 playerPosition = playerObject.transform.position;
            // Check if the player is within the maximum distance
            float distance = Vector3.Distance(transform.position, playerPosition);
            if (distance <= maxDistance)
            {
                if (GameManager.HasItem(itemToCheck))
                {
                    ChildKiller();
                    spawnOject();
                    gameWillRemberThat();

                    //Debug.Log("Player has the " + itemToCheck + " in their inventory!");
                    // Perform any actions or logic specific to having the item
                }
                else
                {
                    //Debug.Log("Player does not have the " + itemToCheck + " in their inventory.");
                }
            }
        }
        
    }
    private void spawnOject(){
       Vector3 spawnPosition = new Vector3(transform.position.x, y, transform.position.z);
        GameObject newObject = Instantiate(objectToSpawn, spawnPosition, rotation);
        // Set the spawned object's parent to be the same as the spawner's parent
        newObject.transform.SetParent(transform.parent);
       
    }
    private void ChildKiller(){
        foreach (Transform child in transform) {
        Destroy(child.gameObject);
            }
    }

    private void gameWillRemberThat(){
        // Create a new Choice object
        Choice choiceNew = new Choice(ChoiceName, description, true, spriteChoice);

        // Find the GameManager object in the scene
        GameManager gameManager = FindObjectOfType<GameManager>();

        // Check if the GameManager object exists
        if (gameManager != null)
        {
            // Call the Beans method in the GameManager and pass the newChoice object
            gameManager.addChoiceToList(choiceNew);
        }
    }

   
 
}
