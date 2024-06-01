using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    [SerializeField] AudioClip[] musicClips;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (musicClips.Length > 0)
        {
            StartCoroutine(PlayRandomMusic());
        }
    }

    IEnumerator PlayRandomMusic()
    {
        while (true)
        {
            AudioClip clip = musicClips[Random.Range(0, musicClips.Length)];
            audioSource.clip = clip;
            audioSource.Play();
            yield return new WaitForSeconds(clip.length);
        }
    }
}
