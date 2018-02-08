using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shadow_Movement : MonoBehaviour {

    public Transform[] Waypoints;
    public float Speed;
    public int curWayPoint;
    public bool doPatrol = true;
    public Vector3 Target;
    public Vector3 MoveDirection;
    public Vector3 Velocity;
    public Transform Player;
    public float aggroDist;
	
	// Update is called once per frame
	void Update () {
        float distance = Vector3.Distance(transform.position, Player.transform.position);
        if (distance > aggroDist)
        {

            if (curWayPoint < Waypoints.Length)
            {
                //Find target waypoint
                Target = Waypoints[curWayPoint].position;
                //Move to target
                MoveDirection = Target - transform.position;
                Velocity = GetComponent<Rigidbody>().velocity;

                if (MoveDirection.magnitude < 1)
                {
                    curWayPoint++;
                }
                else
                {
                    Velocity = MoveDirection.normalized * Speed;
                }
            }
            else
            {
                if (doPatrol)
                {
                    curWayPoint = 0;
                }
                else
                {
                    Velocity = Vector3.zero;
                }
            }
        }
        else
        {
            Target = Player.transform.position;
            MoveDirection = Target - transform.position;
            Velocity = MoveDirection.normalized * Speed;
        }

        GetComponent<Rigidbody>().velocity = Velocity;
        transform.LookAt(Target);
	}
}
