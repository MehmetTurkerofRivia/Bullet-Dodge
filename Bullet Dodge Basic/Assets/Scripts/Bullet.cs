using UnityEngine;

using UnityEngine;

public class Bullet : MonoBehaviour
{
    public AudioClip[] arrowSoundClips; // Oynatýlacak ok seslerinin listesi
    private AudioSource audioSource;
    float speed;
    private void Start()
    {
        speed = Random.Range(0.02f, 0.04f);
        audioSource = GetComponent<AudioSource>();
        PlayRandomArrowSound();
    }
    void Update()
    {
        bulletmovement();
    }
    void bulletmovement()
    {
        transform.localPosition -= new Vector3(speed, 0f, 0f);
        if (transform.localPosition.x <= -21)
        {
            Destroy(gameObject);
            Character.Score += 1;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("blade"))
        {
            Destroy(gameObject);
            Character.Score += 1;
        }
    }
    void PlayRandomArrowSound()
    {
        if (arrowSoundClips.Length > 0)
        {
            AudioClip clip = arrowSoundClips[Random.Range(0, arrowSoundClips.Length)];
            audioSource.PlayOneShot(clip);
        }
    }
}

