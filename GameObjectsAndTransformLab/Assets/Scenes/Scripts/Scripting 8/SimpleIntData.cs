using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[RequireComponent(typeof(TextMeshProUGUI))]

public class SimpleIntData : MonoBehaviour
{
    public int value;

    private TextMeshProUGUI txtObj;
    public float txtTime = 0.7f;
    
    public void UpdateValue(int amount)
    {
        value += amount;
    }
    
    public void SetValue(int amount)
    {
        value = amount;
    }
    
    /*private ChangeTextCoRoutine()
    {
        txtObj.fontSize = 40;
        txtObj.color = Color.black;
        yield return new WaitForSeconds(txtTime);

        txtObj.fontSize = 60;
        txtObj.color = Color.yellow;
         return new WaitForSeconds(txtTime);
        
        txtObj.fontSize = 40;
        txtObj.color = Color.black;
    }*/
}
