using UnityEngine;
using UnityEngine.UI;

public class PopupNotification : MonoBehaviour
{
    private GameObject canvasObject; // Reference to the Canvas object in the scene
    private GameObject popupNotification; // Reference to the Popup Notification child object
    private Text popupText; // Reference to the Text component of the Popup Notification
    private Image IconImage; // Reference to the Image component of the Popup Notification
    private Image  popupPannal; 


    private GameObject popupQestion;
    private Button popupQuestionYes;
    private Button popupQuestionNO;

    
    private void Start()
    {
        // Find the Canvas object in the scene
        canvasObject = GameObject.Find("Canvas(Clone)");

        if (canvasObject != null){
           getPopupNofifications();
           getbuttons();

        }

        HidequestionPannel();
        HidePopupPanel(); // Hide the Popup Panel by default
    }


    private void Update(){
        if (Input.GetKeyDown(KeyCode.V)){
          HidePopupPanel();
          HidequestionPannel();
        }
    }

  private void getPopupNofifications(){
    // Find the Popup Notification child object
    popupNotification = canvasObject.transform.Find("PopupNotification").gameObject;

    if (popupNotification != null)
    {
        // Find the Text component of the Popup Notification
        popupText = popupNotification.GetComponentInChildren<Text>();

        // Find the Image components of the Popup Notification
        Image[] images = popupNotification.GetComponentsInChildren<Image>();
        foreach (Image image in images)
        {
            if (image.gameObject != popupNotification)
            {
                // Assign the Image component to the appropriate reference
                if (image.gameObject.name == "IconImage")
                {
                    IconImage = image;
                }
                else if (image.gameObject.name == "PopupPanel")
                {
                    popupPannal = image;
                }
            }
        }
    }
}

    private void getbuttons(){
        popupQestion = canvasObject.transform.Find("Panel").gameObject;
        if (popupQestion != null){
                    popupQuestionYes = popupNotification.GetComponentInChildren<Button>();
                    popupQuestionNO = popupNotification.GetComponentInChildren<Button>();
                    
                }

    }
    private void HidequestionPannel(){
        popupQestion.SetActive(false);
    }

    public void setPopupText(string text, Sprite sprite)
    {
        popupText.text = text;
        IconImage.sprite = sprite;
        ShowPopupPanel();
        
      
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
