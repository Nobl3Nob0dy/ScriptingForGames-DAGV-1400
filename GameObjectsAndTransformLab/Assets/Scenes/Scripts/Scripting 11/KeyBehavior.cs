using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class KeyBehavior : MonoBehaviour
{
    public ID id;
    public UnityEvent keyState, noMatch;
    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
    {
        var otherID = other.GetComponent<SimpleID>();

        if (otherID.id == id)
        {
            keyState.Invoke();
            //Debug.Log("Correct Key: " + id);
        }
        else
        {
            noMatch.Invoke();
            //Debug.Log("No Match Found");
        }
    }
}
