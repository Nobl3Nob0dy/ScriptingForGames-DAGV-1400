using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.Events;

public class SimpleTrigger : MonoBehaviour
{ 
    
    public UnityEvent triggerEvent;
    private Animator animator;
    
    //public Collider cherryCollider;
    //public Collider sawCollider;
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
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            triggerEvent.Invoke();
            Debug.Log("Player got hit");
            animator.SetTrigger("Hit_Trigger");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Item")
        {
            triggerEvent.Invoke();
            Debug.Log("Player collected cherry");
            animator.SetTrigger("Collect_Trigger");
        }
    }
    
}
