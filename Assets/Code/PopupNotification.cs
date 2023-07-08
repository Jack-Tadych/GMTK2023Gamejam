using UnityEngine;
using UnityEngine.UI;

public class PopupNotification : MonoBehaviour
{
    private GameObject canvasObject; // Reference to the Canvas object in the scene
    private GameObject popupNotification; // Reference to the Popup Notification child object
    private Text popupText; // Reference to the Text component of the Popup Notification

    private void Start()
    {
        // Find the Canvas object in the scene
        canvasObject = GameObject.Find("Canvas");

        if (canvasObject != null)
        {
            // Find the Popup Notification child object
            popupNotification = canvasObject.transform.Find("PopupNotification").gameObject;

            if (popupNotification != null)
            {
                // Find the Text component of the Popup Notification
                popupText = popupNotification.GetComponentInChildren<Text>();

                if (popupText != null)
                {
                    // Change the text of the Popup Notification
                    Debug.Log("popupText found");
                }
                else
                {
                    Debug.LogError("Text component not found in Popup Notification!");
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

    public void setPopupText(string text)
    {
        popupText.text = text;
        ShowPopupPanel();
        Invoke("HidePopupPanel", 2f); // Hide the Popup Panel after 2 seconds
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
