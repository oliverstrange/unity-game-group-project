using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waypointFollower : MonoBehaviour
{
    //allows parameters to be changed in Unity. This allows adding multiple waypoints.
    [SerializeField] private GameObject[] waypoints;
    // checking which waypoint we are moving towards
    private int currentPointInd = 0;

    //speed movement
    [SerializeField] private float speed = 2f;
       
    private void Update()
    {
        //set position of platform so can move towards other one. This returns boolean
        if (Vector2.Distance(waypoints[currentPointInd].transform.position, transform.position) < .1f)
        {
            currentPointInd++;
            if (currentPointInd >= waypoints.Length)
            {
                currentPointInd = 0;
            }
        }
        //move platform towards next waypoint, deltaTime makes it frameweight independent (2 game units per second)
        transform.position = Vector2.MoveTowards(transform.position, waypoints[currentPointInd].transform.position, Time.deltaTime * speed);
    }
}
