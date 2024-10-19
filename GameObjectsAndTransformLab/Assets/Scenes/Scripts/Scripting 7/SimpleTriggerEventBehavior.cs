using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class SimpleTriggerEventBehavior : MonoBehaviour
{
    
    public UnityEvent triggerEvent;
    
    public void OnTriggerEnter(Collider other)
    {
        triggerEvent.Invoke();
    }
    
}