using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshNav : MonoBehaviour
{
    public Transform player;

    public NavMeshAgent navAgent;

    private NavMeshPath navPath;

    private float timeElapsed = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        navAgent = GetComponent<NavMeshAgent>();

        navPath = new NavMeshPath();

        timeElapsed = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        //Set the timeElapsed as the amount of time passed it Time.deltaTime
        timeElapsed += Time.deltaTime;

        //Set the function to run as long as any amount of time has passed
        if (timeElapsed > 1.0f)
        {
            //Increase the timeElapsed by 1 
            timeElapsed -= 1.0f;
            //Calculate the NavMesh from the enemy position to the player position
            navAgent.SetDestination(player.position);
        }
    }
}
