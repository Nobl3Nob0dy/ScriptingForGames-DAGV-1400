using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FireBehavior : MonoBehaviour
{
    private Animator _animator;
    
    public ID id;
    public UnityEvent fireToggle, noMatch;
    
    // Start is called before the first frame update
    void Start()
    {
     gameObject.tag = "Enemy";   
     _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Transform childObject = transform.GetChild(0);
    }

    private void OnTriggerEnter(Collider other)
    {
        fireToggle.Invoke();
        
        var otherID = other.GetComponent<SimpleID>();

        if (otherID.id == id)
        {
            if (_animator.GetCurrentAnimatorStateInfo(0).IsName("fireOn"))
            {
                _animator.SetBool($"fireToggle", false);
                Destroy(transform.GetChild(0).gameObject);
            }

            if (_animator.GetCurrentAnimatorStateInfo(0).IsName("fireOff"))
            {
                _animator.SetBool($"fireToggle", true);
                Instantiate(transform.GetChild(0).gameObject, transform.GetChild(0).transform.position, Quaternion.identity);
            }
            Debug.Log("Correct Key: " + id);
            gameObject.tag = "Obstacle";
        }
        else
        {
            noMatch.Invoke();
            Debug.Log("No Match Found");
        }
    }
}
