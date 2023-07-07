using UnityEngine;

public class GameManager : MonoBehaviour
{
    private bool isKnifeClicked = false;

    private void Update()
    {
        // Check for mouse click
        if (Input.GetMouseButtonDown(0))
        {
            // Cast a ray from the mouse position
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            // Check if the ray hits the knife object
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.CompareTag("Knife"))
                {
                    // Knife object is clicked
                    isKnifeClicked = true;
                    Debug.Log("Knife has been clicked!");
                }
            }
        }
    }

    // Example function to check if the knife has been clicked
    public bool IsKnifeClicked()
    {
        return isKnifeClicked;
    }
}
