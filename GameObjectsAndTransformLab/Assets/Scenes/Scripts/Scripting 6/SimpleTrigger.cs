using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class SimpleTrigger : MonoBehaviour
{ 
    public UnityEvent triggerEvent;
    private Animator animator;
    public void Update()
    {
        GetInput();
    }
    
    public void GetInput()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            triggerEvent.Invoke();
            Debug.Log("Player casted a Spell");
            animator.SetTrigger("DoubleJump_Trigger");
        }
    }
    
    public void OnTriggerEnter(Collider other)
    {
        triggerEvent.Invoke();
        Debug.Log("Player interacted with object");
        animator.SetTrigger("Hit_Trigger");
        
    }
}
