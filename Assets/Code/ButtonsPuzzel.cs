using UnityEngine;
using UnityEngine.UI;

public class ButtonsPuzzel : MonoBehaviour
{
    public Text displayText; // Reference to the text component where the button inputs will be displayed

    public void NumberButtonPressed(int number)
    {
        displayText.text += number.ToString();
    }

    public void ClearButtonPressed()
    {
        displayText.text = string.Empty;
    }

    public void EnterButtonPressed()
    {
        // Perform actions when the enter button is pressed
        string input = displayText.text;
        // Do something with the input (e.g., process it, display it, etc.)

        // Clear the display after processing the input
        ClearButtonPressed();
    }
}
