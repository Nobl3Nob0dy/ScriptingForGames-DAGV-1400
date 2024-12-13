using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipTransform : MonoBehaviour
{
    public float direction1 = 0, direction2 = 180;
    private Vector3 _velocity;
    public Vector3 oldPosition;

    private void FixedUpdate()
    {
        /*Vector3 localVelocity = transform.InverseTransformVector(_velocity);
        Vector3 direction = transform.position - oldPosition;

        if (Mathf.Abs(_velocity.x) > 0.01f)
        {
            transform.rotation = Quaternion.Euler(0f, direction1, 0f);
        } else if (Mathf.Abs(_velocity.x) < 0.01f)
        {
            transform.rotation = Quaternion.Euler(0f, direction2, 0f);
        }*/
        Vector3 direction = transform.position - oldPosition;
        float forwardTest = Vector3.Dot(-direction.normalized, transform.position.normalized);

        if (forwardTest > 0)
        {
           transform.rotation = Quaternion.Euler(0f, direction2, 0f);
        }else if (forwardTest < 0)
        {
            transform.rotation = Quaternion.Euler(0f, direction1, 0f);
        }

        oldPosition = transform.position;
    }
}
