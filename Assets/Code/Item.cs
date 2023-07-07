using UnityEngine;

public class Item : MonoBehaviour
{
    public string itemName;
    public Sprite itemIcon;
    public float maxDistance = 2f; // Maximum distance allowed for picking up the item

    private void OnMouseDown()
    {
        GameObject playerObject = GameObject.FindWithTag("Player");
        if (playerObject != null)
        {
            Vector3 playerPosition = playerObject.transform.position;
            // Check if the player is within the maximum distance
            float distance = Vector3.Distance(transform.position, playerPosition);
            if (distance <= maxDistance)
            {
                InventoryManager inventoryManager = FindObjectOfType<InventoryManager>();
                inventoryManager.AddItem(this);
                gameObject.SetActive(false);
            }
        }
    }

    public string GetItemName()
    {
        return itemName;
    }

    public Sprite GetItemIcon()
    {
        return itemIcon;
    }
}
