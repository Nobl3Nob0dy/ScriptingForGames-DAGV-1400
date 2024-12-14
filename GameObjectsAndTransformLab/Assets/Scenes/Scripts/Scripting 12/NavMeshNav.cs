using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshNav : MonoBehaviour
{
    public Transform target;
    public NavMeshAgent navAgent;
    private NavMeshPath navPath;
    public Transform[] wayPoints;

    public Animator _animator;
    private float timeElapsed = 0.1f;
    
    // Start is called before the first frame update
    void Start()
    {
        navAgent = GetComponent<NavMeshAgent>();
        navPath = new NavMeshPath();
        timeElapsed = 0.0f;
        
        StartCoroutine(FollowTarget());
    }

    private IEnumerator FollowTarget()
    {
        WaitForSeconds wait = new WaitForSeconds(timeElapsed);

        while (enabled)
        {
            navAgent.SetDestination(target.position);
            yield return wait;
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        _animator.SetBool($"isMoving", navAgent.velocity.magnitude > 0.01f);
    }
}
