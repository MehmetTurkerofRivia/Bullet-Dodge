using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    private Animator animator;
    private bool isHit = false;
    void Start()
    {
        animator = GetComponent<Animator>();    
    }
    void Update()
    {
        if((Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D)) && isHit==false)
        {
            animator.SetInteger("AnimSelect", 1);
        }
        else
            animator.SetInteger("AnimSelect", 0);

        if (Input.GetMouseButtonUp(0) && isHit == false)
        {
            StartCoroutine(HitAnim());
        }       
    }

    IEnumerator HitAnim()
    {
        yield return new WaitForSeconds(1f);
        animator.SetInteger("AnimSelect", 2);
        isHit = true;
        yield return new WaitForSeconds(3f);
        animator.SetInteger("AnimSelect", 0);
        isHit= false;
    }
}
