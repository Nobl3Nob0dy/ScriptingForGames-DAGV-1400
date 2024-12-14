using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Single Variable/Way Points")]
public class WayPoints : ScriptableObject
{
    /*protected float awareRadius = 20.0f;
    List<ConnectedWaypoint> wayPoints;
    
    // Start is called before the first frame update
    void Start()
    {
        GameObject[] allWayPoints = GameObject.FindGameObjectsWithTag("WayPoint");

        wayPoints = new list<ConnectedWaypoint>();

        for (int i = 0; i < allWayPoints.Length; i++)
        {
            ConnectedWaypoint nextWayPoint = allWayPoints[i].GetComponent<ConnectedWaypoint>();

            if (nextWayPoint != null)
            {
                if (Vector2.Distance(this.transform.position, nextWayPoint.transform.position) < awareRadius &&
                    nextWayPoint != this)
                {
                    wayPoints.Add(nextWayPoint);
                }
            }
        }
    }

    public ConnectedWayPoint GetClosestWayPoint(ConnectedWayPoint, lastWayPoint)
    {
        if (wayPoints.Count == 0)
        {
            Debug.Log("No WayPoints Found");
            return null;
        }else if (wayPoints.Count == 1 && wayPoints.Contains(lastWayPoint))
        {
            return lastWayPoint;
        }
        else
        {
            ConnectedWayPoint nextWayPoint;
            int nextIndex = 0;
            do
            {
                nextIndex = UnityEngine.
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }*/
}
