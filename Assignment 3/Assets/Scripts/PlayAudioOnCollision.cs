using Oculus.Interaction;
using UnityEngine;

public class PlayAudioOnCollision : MonoBehaviour
{
    public AudioSource audioSource;

    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("Collision");
        audioSource.PlayOneShot(audioSource.clip);
    }
}
