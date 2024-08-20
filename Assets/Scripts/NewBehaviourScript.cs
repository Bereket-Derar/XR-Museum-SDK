using UnityEngine;

public class CharacterControllerScript : MonoBehaviour
{
    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        float move = Input.GetAxis("Vertical");  // Adjust this for your input method
        animator.SetFloat("Speed", move);

        if (Input.GetKeyDown(KeyCode.Space))  // Space bar for waving animation
        {
            animator.SetTrigger("Wave");
        }
    }
}

