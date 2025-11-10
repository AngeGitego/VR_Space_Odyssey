using UnityEngine;

public class PlanetHoverSound : MonoBehaviour
{
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("MainCamera") && !audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }
}