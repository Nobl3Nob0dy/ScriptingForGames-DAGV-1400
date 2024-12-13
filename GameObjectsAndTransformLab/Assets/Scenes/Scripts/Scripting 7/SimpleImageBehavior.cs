using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class SimpleImageBehavior : MonoBehaviour
{
    public Image imageObj;
    public SimpleFloatData dataObj;
    
    // Start is called before the first frame update
    void Start()
    {
        imageObj = GetComponent<Image>();
        dataObj.SetValue(1f);
    }

    /*public void Update()
    {
        imageObj.rectTransform.sizeDelta = new Vector2(dataObj.value * imgScaler, rectTransform.sizeDelta.y);
    }*/

    
    void Update()
    {
        imageObj.fillAmount = dataObj.value;
    }
}
