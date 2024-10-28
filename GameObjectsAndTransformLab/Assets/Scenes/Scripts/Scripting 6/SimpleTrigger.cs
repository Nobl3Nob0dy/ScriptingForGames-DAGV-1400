using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SimpleTrigger : MonoBehaviour
{ 
    public UnityEvent triggerEvent;
    private Animator animator;
    
    void start()
    {
        animator = GetComponent<Animator>();
    }
    public void OnTriggerEnter(Collider other)
    {
        triggerEvent.Invoke();
        Debug.Log("Player interacted with object");
        animator.SetTrigger("Hit_Trigger");
        
    }
}
