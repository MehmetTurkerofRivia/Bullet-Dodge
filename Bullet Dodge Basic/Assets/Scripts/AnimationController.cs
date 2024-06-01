using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    private Animator animator; 
    private bool isAttack = false;
    private bool attackCD = true;
    [SerializeField] GameObject Bladepf;
    public AudioClip[] swordSounds; // Oynatýlacak kýlýç seslerinin listesi
    private AudioSource audioSource;
    void Start()
    {
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }
    void Update()
    {
       if (isAttack == false)
        {
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
            {
                animator.SetInteger("AnimSelect", 1);
            }
            else
                animator.SetInteger("AnimSelect", 0);

            if ((Input.GetMouseButtonDown(0)) && attackCD == true)
            {
                StartCoroutine(AttackAnim()); 
            }
        }             
    }
    public void PlayRandomSwordSound()
    {
        if (swordSounds.Length > 0)
        {
            AudioClip clip = swordSounds[Random.Range(0, swordSounds.Length)];
            audioSource.PlayOneShot(clip);
        }
    }
    IEnumerator AttackAnim()
    {
        isAttack = true;
        attackCD = false;
        Bladepf.SetActive(true);           
        animator.SetInteger("AnimSelect", 2);
        PlayRandomSwordSound();
        yield return new WaitForSeconds(0.3f);
        Bladepf.SetActive(false);
        yield return new WaitForSeconds(0.3f);
        animator.SetInteger("AnimSelect", 0);          
        isAttack = false;
        yield return new WaitForSeconds(1f);
        attackCD = true;
    }
}
