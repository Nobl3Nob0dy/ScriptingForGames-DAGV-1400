using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Scrpiting3 : MonoBehaviour
{
    public float bounceForce = 5f;

    public Color[] newColors = new Color[] { Color.red, Color.green, Color.yellow };

    public float shrinkGrow = 0f;
    public Vector3 shrink;
    private void OnCollisionEnter(Collision other)
    {
        GetComponent<Rigidbody>().AddForce(Vector3.up * bounceForce, ForceMode.Impulse);
        
        int i = Random.Range(0, newColors.Length);
        GetComponent<Renderer>().material.color = newColors[i];

        Vector3 shrink = new Vector3(1, 1, 1);
        transform.localScale = shrink;
        //float shrinkGrow = Random.Range(0.1f, 5f);
        //transform.localScale *= shrinkGrow;
    }

    private void OnCollisionExit(Collision other)
    {
        float shrinkGrow = Random.Range(0.1f, 5f);
        transform.localScale *= shrinkGrow;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
