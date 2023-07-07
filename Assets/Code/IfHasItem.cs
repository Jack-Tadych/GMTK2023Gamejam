using UnityEngine;

public class IfHasItem : MonoBehaviour
{
    public string itemToCheck = ""; // The item name to check in the inventory
    public GameObject objectToSpawn;
    private void OnMouseDown()
    {
       

        InventoryManager inventoryManager = FindObjectOfType<InventoryManager>();

        // Check if the specified item is in the inventory
        if (inventoryManager.HasItem(itemToCheck))
        {
            ChildKiller();
            spawnOject();
            

            Debug.Log("Player has the " + itemToCheck + " in their inventory!");
            // Perform any actions or logic specific to having the item
        }
        else
        {
            Debug.Log("Player does not have the " + itemToCheck + " in their inventory.");
        }
    }
    private void spawnOject()
    {
       GameObject newObject = Instantiate(objectToSpawn,transform.position, transform.rotation);
       print(transform.position);
    }
    private void ChildKiller()
    {
    foreach (Transform child in transform) {
     Destroy(child.gameObject);
        }
    }
}
