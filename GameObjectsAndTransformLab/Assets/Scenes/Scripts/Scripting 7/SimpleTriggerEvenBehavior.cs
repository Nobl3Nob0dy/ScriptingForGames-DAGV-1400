using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class SimpleTriggerEvenBehavior : MonoBehaviour
{
    public UnityEvent triggerEvent;
    private Image imageObj;
    public SimpleFloatData;

    private void OnTriggerEnter(Collider other)
    {
        triggerEvent.Invoke();
    }

    public void UpdateWithFloatData(SimpleFloatData data)
    {
        imageObj = GetComponent<Image>();
    }
}
