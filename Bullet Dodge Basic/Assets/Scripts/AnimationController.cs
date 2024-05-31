using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    private Animator animator; 
    private bool isAttack = false;
    private bool attackCD = true;
    void Start()
    {
        animator = GetComponent<Animator>();    
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

    IEnumerator AttackAnim()
    {
        isAttack = true;
        attackCD = false;
        animator.SetInteger("AnimSelect", 2);
        yield return new WaitForSeconds(0.5f);
        animator.SetInteger("AnimSelect", 0);
        isAttack = false;
        yield return new WaitForSeconds(1f);
        attackCD = true;
    }
}
