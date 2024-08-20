using UnityEngine;
using UnityEngine.XR;

public class VRCharacterController : MonoBehaviour
{
    private Animator animator;
    private XRNode inputSource = XRNode.Head;
    private InputDevice device;

    void Start()
    {
        animator = GetComponent<Animator>();
        device = InputDevices.GetDeviceAtXRNode(inputSource);
    }

    void Update()
    {
        // Check if the VR headset is on
        device.TryGetFeatureValue(CommonUsages.userPresence, out bool userPresent);

        if (userPresent)
        {
            // Trigger walking animation (e.g., when the user moves forward)
            if (Input.GetAxis("Vertical") > 0.1f)
            {
                animator.SetTrigger("Walk");
            }

            // Trigger waving animation (e.g., when the user presses a button)
            if (Input.GetButtonDown("Fire1")) // Replace with your input for waving
            {
                animator.SetTrigger("Wave");
            }
        }
        else
        {
            // Reset the animation to idle if the user is not wearing the headset
            animator.ResetTrigger("Wave");
            animator.ResetTrigger("Walk");
        }
    }
}
