using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScreen : MonoBehaviour
{
    public void StartNewGame()
    {
        // TODO: Add code to start a new game
        SceneManager.LoadScene(1);
    }

    public void GoToCredits()
    {
        // TODO: Add code to go to the credits scene
       
        Debug.Log("Credits checkit...");
    }

    public void ExitGame()
    {
        // TODO: Add code to exit the game
        Debug.Log("Exiting the game...");
        Application.Quit();
    }
}
