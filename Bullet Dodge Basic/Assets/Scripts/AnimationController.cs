using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    private Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();    
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            animator.SetInteger("AnimSelect", 1);
        }
        else 
            animator.SetInteger("AnimSelect", 0);

        if (Input.GetMouseButtonDown(0))
        {
             animator.SetInteger("AnimSelect", 2);
        }   
    }
}
