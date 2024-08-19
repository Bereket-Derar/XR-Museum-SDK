using UnityEngine;
using UnityEngine.SceneManagement;
using Oculus.Interaction;
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
            LoadNextScene();
        }
    }
    void LoadNextScene()
    {
        // Load the scene named "Scene VR"
        SceneManager.LoadScene("Scene VR");
    }
}
