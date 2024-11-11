using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using TMPro;
using UnityEngine;

[RequireComponent(typeof(TextMeshProUGUI))]
public class TextMechProBehavior : MonoBehaviour
{
    private TextMeshProUGUI txtObj;
    public SimpleIntData intData;
    
    // Start is called before the first frame update
    private void Start()
    {
        txtObj = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        UpdateWithIntData();
    }

    public void UpdateWithIntData()
    {
        txtObj.text = intData.value.ToString(CultureInfo.InvariantCulture);
    }
}
