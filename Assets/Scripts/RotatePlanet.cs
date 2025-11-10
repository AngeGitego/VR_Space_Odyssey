using UnityEngine;

public class RotatePlanet : MonoBehaviour
{
    // Adjustable in Inspector
    public float rotationSpeed = 30f; // Degrees per second

    void Update()
    {
        // Rotate around local Y axis (up)
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime, Space.Self);
    }
}