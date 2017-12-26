using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI; // Now able to use fucntions within unity for AI

public class Waypoint : MonoBehaviour {

    NavMeshAgent NavPoint; // Declared the navMeshAgent to be called NavPoint
    public Transform[] Waypoints;
    public int curr_loc; // Current location
    public float stop_distance;

	
	void Start () {

        NavPoint = GetComponent<NavMeshAgent>();
        NavPoint.stoppingDistance = stop_distance;
        
	}
	
	// Update is called once per frame
	void Update () {

        float distance = Vector3.Distance(transform.position, Waypoints[curr_loc].position); // Finds the distance between the player location and waypoint

        transform.LookAt(Waypoints[curr_loc]); // Face the waypoint selected

        if (distance <= stop_distance) // once the player has arrived at the waypoint and the distance is less or equal to stop_distance then...
        {
            curr_loc += 1; // add 1
        }

        if (curr_loc >= Waypoints.Length) // once the player has arrived at the waypoint but the distance is more than stop_distance then...
        {
            curr_loc = 0; // reset it and make it equal to 0
        }

        if (curr_loc == 0) // if the current location of the waypoint is 0 then...
        {
            NavPoint.SetDestination(Waypoints[0].position); // use NavmeshAgent to set pathway 0 in the Waypoints array
        }

        if (curr_loc == 1) // // if the current location of the waypoint is 1 then...
        {
            NavPoint.SetDestination(Waypoints[1].position); // use NavmeshAgent to set pathway 1 in the Waypoints array 
        }

        if (curr_loc == 2) // // if the current location of the waypoint is 2 then...
        {
            NavPoint.SetDestination(Waypoints[2].position); // use NavmeshAgent to set pathway 2 in the Waypoints array
        }

    }
}
