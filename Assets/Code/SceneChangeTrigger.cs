using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeTrigger : MonoBehaviour
{
    public string targetScene; // The name of the scene to load

    private void OnTriggerEnter(Collider other)
    {
  
        if (other.CompareTag("Player"))
        {
  
            // Check if the player presses the "E" key
         
                print(targetScene);
                // Load the target scene
                SceneManager.LoadScene(targetScene);
            
        }
    }
}
