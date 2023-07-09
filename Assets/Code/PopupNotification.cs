using UnityEngine;
using UnityEngine.UI;

public class PopupNotification : MonoBehaviour
{
    private GameObject canvasObject; // Reference to the Canvas object in the scene
    private GameObject popupNotification; // Reference to the Popup Notification child object
    private Text popupText; // Reference to the Text component of the Popup Notification
    private Image popupImage; // Reference to the Image component of the Popup Notification

    private void Start()
    {
        // Find the Canvas object in the scene
        canvasObject = GameObject.Find("Canvas(Clone)");

        if (canvasObject != null)
        {
            // Find the Popup Notification child object
            popupNotification = canvasObject.transform.Find("PopupNotification").gameObject;

            if (popupNotification != null)
            {
                // Find the Text and Image components of the Popup Notification
                popupText = popupNotification.GetComponentInChildren<Text>();
                popupImage = popupNotification.GetComponentInChildren<Image>();

                if (popupText != null && popupImage != null)
                {
                    // Change the text of the Popup Notification
                    // Debug.Log("popupText and popupImage found");
                }
                else
                {
                    Debug.LogError("Text or Image component not found in Popup Notification!");
                }
            }
            else
            {
                Debug.LogError("Popup Notification object not found!");
            }
        }
        else
        {
            Debug.LogError("Canvas object not found!");
        }

        HidePopupPanel(); // Hide the Popup Panel by default
    }

    public void setPopupText(string text, Sprite sprite)
    {
        popupText.text = text;
        ChangePopupImage(sprite); // Call the method to change the popup image
        ShowPopupPanel();
        Invoke("HidePopupPanel", 2f); // Hide the Popup Panel after 2 seconds
    }

    private void ChangePopupImage(Sprite sprite)
    {
        if (popupNotification != null)
        {
            Image[] imageComponents = popupNotification.GetComponentsInChildren<Image>();
            foreach (Image imageComponent in imageComponents)
            {
                if (imageComponent.gameObject != popupNotification)
                {
                    imageComponent.sprite = sprite;
                    break;
                }
            }
        }
        else
        {
            Debug.LogError("Popup Notification object not found!");
        }
    }

    private void ShowPopupPanel()
    {
        popupNotification.SetActive(true);
    }

    private void HidePopupPanel()
    {
        popupNotification.SetActive(false);
    }
}
