using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimationController : MonoBehaviour
{
    private Animator animator;
    public CharacterController controller;

    
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        HandleAnimations();
    }

    private void HandleAnimations()
    {
        if (Input.GetAxis("Horizontal") != 0)
        {
            animator.SetTrigger("Run_Trigger");
        } else
        {
            animator.SetTrigger("Idle");
        }
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("Jump_Trigger");
        }
        
        /*if (Input.GetKeyDown(KeyCode.Q))
        {
            animator.SetTrigger("DoubleJump_Trigger");
        }*/
        
        if (Input.GetKeyDown(KeyCode.W))
        {
            animator.SetTrigger("WallJump_Trigger");
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            animator.SetTrigger("Hit_Trigger");
        }
    }
}
