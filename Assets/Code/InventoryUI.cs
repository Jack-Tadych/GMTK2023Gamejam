using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    // Reference to the Canvas or UI element you want to show/hide
    public GameObject uiElement;
    private Animator animator;

    private void Start()
    {
        // Disable the UI element on start
        uiElement.SetActive(false);

        // Get the Animator component attached to the UI element
        animator = uiElement.GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            bool isOpen = !uiElement.activeSelf;

            // Toggle the UI element's visibility
            uiElement.SetActive(isOpen);

            // Trigger animation based on UI state
            if (animator != null)
            {
                animator.SetBool("IsOpen", isOpen);
            }
        }
    }
}
