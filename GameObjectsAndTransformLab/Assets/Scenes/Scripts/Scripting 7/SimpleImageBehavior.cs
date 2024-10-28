using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]

public class SimpleImageBehavior : MonoBehaviour
{
    private Image imageObj;
    public SimpleFloatData dataObj;
    
    // Start is called before the first frame update
    void Start()
    {
        imageObj = GetComponent<Image>();
    }

    // Update is called once per frame
    public void UpdateWithFloatData()
    {
        imageObj.fillAmount = dataObj.value;
    }
}
