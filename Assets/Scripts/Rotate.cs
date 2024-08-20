using UnityEngine;
public class Rotate : MonoBehaviour
{
    public float rotationSpeed = 40f; // Rotation speed in degrees per second
    private float elapsedTime = 0f;
    private bool isRotating = true;
    void Update()
    {
        if (isRotating)
        {
            // Rotate the cube around its x-axis only
            transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
            // Update the elapsed time
            elapsedTime += Time.deltaTime;
            // Stop rotating after 30 seconds
            if (elapsedTime >= 15f)
            {
                isRotating = false;
            }
        }
    }
}