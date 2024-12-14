using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.AI;

public class NavMeshPatrolAI : MonoBehaviour
{
    public Transform[] waypoints;
    public Transform target;
    private int currentWaypointIndex;
    private NavMeshAgent navAgent;

    public bool patrolWaiting;
    private float totalWaitTime = 3.0f;
    private float waitTime;

    public float trackingDist;
    
    private DistanceComparer distanceComp; 
    
    public Animator _animator;
    
    
    // Start is called before the first frame update
    void Start()
    {
        distanceComp= new DistanceComparer(transform); 
        
        navAgent = GetComponent<NavMeshAgent>();

        if (waypoints.Length >= 2)
        {
            navAgent.SetDestination(waypoints[0].position);
        } else
        {
            Debug.Log("No Waypoints Found");
            return;
        }
        
        GameObject[] allWaypoints = GameObject.FindGameObjectsWithTag("Waypoint");
        if (allWaypoints.Length > 0)
        {
            /*while (currentWaypoint == null)
            {
                
            }*/
        }
    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(target.position, transform.position);

        if (dist <= trackingDist)
        {
            navAgent.SetDestination(target.position);
        }
        
        if (patrolWaiting)
        {
            waitTime += Time.deltaTime;
            if (waitTime >= totalWaitTime)
            {
                patrolWaiting = false;

                SetDestination();

            }
        }else
        {
            SetDestination();
        }
        _animator.SetBool($"isMoving", navAgent.velocity.magnitude > 0.01f);
    }
    
    void SetDestination()
    {
        if (navAgent.remainingDistance <= navAgent.stoppingDistance)
        {
            currentWaypointIndex = (currentWaypointIndex + 1) % waypoints.Length;
            navAgent.SetDestination(waypoints[currentWaypointIndex].position);
            
        }
    }
    
    public class DistanceComparer : IComparer<Transform>
    {
        private Transform target;

        public DistanceComparer(Transform targetDistance)
        {
            target = targetDistance;
        }

        public int Compare(Transform x, Transform y)
        {
            var targetPosition = target.position;
            return Vector3.Distance(x.position, targetPosition).CompareTo(Vector3.Distance(y.position, targetPosition));
        }
    }

}
