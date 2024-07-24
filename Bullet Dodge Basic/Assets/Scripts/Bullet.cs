using UnityEngine;

public class Bullet : MonoBehaviour
{
    public AudioClip[] arrowSoundClips;
    private AudioSource audioSource;
    float speed;

    private void Start()
    {
        speed = Random.Range(0.3f, 0.4f);
        audioSource = GetComponent<AudioSource>();
        PlayRandomArrowSound();
    }

    void FixedUpdate()
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

        if (collision.gameObject.CompareTag("Character"))
        {
            // Find the Reload component attached to a GameObject in the scene
            Reload reload = FindObjectOfType<Reload>();
            if (reload != null)
            {
                reload.Death();
                
                
                Bullet[] bullets = FindObjectsOfType<Bullet>();

                // Destroy each bullet
                foreach (Bullet bullet in bullets)
                {
                    Destroy(bullet.gameObject);
                }
            }
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
