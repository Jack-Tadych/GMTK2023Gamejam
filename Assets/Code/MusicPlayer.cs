using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    public AudioClip musicClip; // The music clip to play
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = musicClip;
        audioSource.loop = true; // Enable looping
        audioSource.Play(); // Start playing the music
    }
}
