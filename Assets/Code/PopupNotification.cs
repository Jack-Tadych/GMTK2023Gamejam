using UnityEngine;
using UnityEngine.UI;

public class PopupNotification : MonoBehaviour
{
    private GameObject canvasObject; // Reference to the Canvas object in the scene
    private GameObject popupNotification; // Reference to the Popup Notification child object
    private Text popupText; // Reference to the Text component of the Popup Notification
    private Image popupImage; // Reference to the Image component of the Popup Notification
    private Image  popupPannal; 


    private GameObject popupQestion;
    private Button popupQuestionYes;
    private Button popupQuestionNO;

    
    private void Start()
    {
        // Find the Canvas object in the scene
        canvasObject = GameObject.Find("Canvas(Clone)");

        if (canvasObject != null)
        {
            // Find the Popup Notification child object
            popupNotification = canvasObject.transform.Find("PopupNotification").gameObject;
            popupQestion = canvasObject.transform.Find("Panel").gameObject;

            

            if (popupNotification != null)
            {
                      print("Help");
                // Find the Text and Image components of the Popup Notification
                popupText = popupNotification.GetComponentInChildren<Text>();
                popupImage = popupNotification.GetComponentInChildren<Image>();
                popupPannal = popupNotification.GetComponentInChildren<Image>();
     
            }
            if (popupQestion != null){
                popupQuestionYes = popupNotification.GetComponentInChildren<Button>();
                popupQuestionNO = popupNotification.GetComponentInChildren<Button>();
                 
            }

        }


        HidePopupPanel(); // Hide the Popup Panel by default
    }

    private void Update(){
        if (Input.GetKeyDown(KeyCode.V)){
          HidePopupPanel();
          HidequestionPannel();
        }
    }
    public void setPopupText(string text, Sprite sprite)
    {
        popupText.text = text;
        ChangePopupImage(sprite); // Call the method to change the popup image
        ShowPopupPanel();
        
      
    }


    public void HidequestionPannel(){
        popupQestion.SetActive(false);
    }
    
    
    public void Yes()
    {
        Debug.Log("Yes");
    }

    public void No()
    {
        Debug.Log("No");
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
