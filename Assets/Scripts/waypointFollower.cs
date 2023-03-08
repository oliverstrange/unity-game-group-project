using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waypointFollower : MonoBehaviour
{
    // this can be used for multiple waypoints, by creating an array using []. serializeField means it can be changed in editor
    [serializeFiled] private GameObject[] waypoints;
    //Keeps stack curretn waypoint index
    private int currentWaypointIndex = 0;

    // speed moving platform
    [SerializeField] private float speed = 2f;

    // Update is called once per frame
    private void Update()
    {
        //True or False of each frame for distance from waypoint
        if (Vector2.Distance(waypoints[currentWaypointIndex].transform.position, transform.position) < .1f)
        {
            currentWaypointIndex++;
            if (currentWaypointIndex >= waypoints.Length)
            {
                currentWaypointIndex = 0;
            }
            // making framerate independent
            transform.position = Vector2.MoveTowards(transform.position, waypoints[currentWaypointIndex].transform.position, Time.deltaTime * speed);

        }
    }
}
