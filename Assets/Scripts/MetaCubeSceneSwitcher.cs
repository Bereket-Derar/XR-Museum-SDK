using UnityEngine;
using UnityEngine.SceneManagement;
using Oculus.Interaction;
using System.Collections;
using Oculus.Interaction.HandGrab;
public class MetaCubeSceneSwitcher : MonoBehaviour
{
    // This method is called when another collider enters the trigger
    private void OnTriggerEnter(Collider other)
    {
        // Check if the object that interacted with the cube is a hand with a HandGrabInteractor
        HandGrabInteractor handGrabInteractor = other.GetComponentInParent<HandGrabInteractor>();
        if (handGrabInteractor != null)
        {
            StartCoroutine(LoadNextSceneWithDelay());
        }
    }
    // Coroutine 3-second delay
    IEnumerator LoadNextSceneWithDelay()
    {
        yield return new WaitForSeconds(4);  // Wait for 3 seconds
        SceneManager.LoadScene("Scene VR");  // Load the scene named "Scene VR"
    }
}
