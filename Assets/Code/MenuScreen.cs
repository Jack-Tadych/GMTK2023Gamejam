using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScreen : MonoBehaviour
{
    public void StartNewGame()
    {
        // TODO: Add code to start a new game
        Debug.Log("Starting a new game...");
    }

    public void ContinueGame()
    {
        // TODO: Add code to continue the game
        Debug.Log("Continuing the game...");
    }

    public void GoToCredits()
    {
        // TODO: Add code to go to the credits scene
       
        Debug.Log("Credits checkit...");
        SceneManager.LoadScene("Credits");
    }

    public void ExitGame()
    {
        // TODO: Add code to exit the game
        Debug.Log("Exiting the game...");
        Application.Quit();
    }
}
