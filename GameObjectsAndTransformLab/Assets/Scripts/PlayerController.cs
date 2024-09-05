using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformController : MonoBehaviour
{
    public GameObject sphere;
    public Vector3 scaleChange;

    // Start is called before the first frame update
    void Start()
    {
        scaleChange = new Vector3(-0.01f, -0.01f, -0.01f);
    }

    // Update is called once per frame
    void Update()
    {
        sphere.transform.localScale += scaleChange;

        var x = Mathf.PingPong(Time.time, 3);
        var p = new Vector3(0,x,0);
        transform.position = p;

        transform.Rotate(new Vector3(0,30,0) * Time.deltaTime);

        if (sphere.transform.localScale.y < 0.1f || sphere.transform.localScale.y > 1.0f){
            scaleChange = -scaleChange;
        }
    }
}
