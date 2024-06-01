using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowSoundEffect : MonoBehaviour
{
    public AudioClip[] arrowSoundClips; // Oynatýlacak ok seslerinin listesi
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayRandomArrowSound()
    {
        if (arrowSoundClips.Length > 0)
        {
            AudioClip clip = arrowSoundClips[Random.Range(0, arrowSoundClips.Length)];
            audioSource.PlayOneShot(clip);
        }
    }
}
