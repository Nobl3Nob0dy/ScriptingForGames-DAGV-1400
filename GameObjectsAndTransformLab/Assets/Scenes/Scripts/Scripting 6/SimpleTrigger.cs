using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.Events;

public class SimpleTrigger : MonoBehaviour
{ 
    
    public UnityEvent triggerEvent;
    private Animator _animator;

    private SimpleFloatData manaData;
    public SimpleFloatData manaNeed;

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
            _animator.SetTrigger("DoubleJump_Trigger");
            
        }
    }
    
    /*private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            triggerEvent.Invoke();
            Debug.Log("Player got hit");
            _animator.SetTrigger("Hit_Trigger");
        }
        if (other.gameObject.tag == "Item")
        {
            triggerEvent.Invoke();
            Debug.Log("Player collected cherry");
            _animator.SetTrigger("Collect_Trigger");
        }
    }*/

    /*private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Item")
        {
            triggerEvent.Invoke();
            Debug.Log("Player collected cherry");
            _animator.SetTrigger("Collect_Trigger");
        }
    }*/
    
}
