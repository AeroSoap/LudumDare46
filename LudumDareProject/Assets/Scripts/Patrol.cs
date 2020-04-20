/*
 Patrol.cs
 By Liam Binford
 Last Edied 4/19/20
 Makes an object move left and right
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    Vector3 target;
    public float targetX;
    Vector3 startingPos;
    public float speed;
    Vector3 newTarget;

    // Start is called before the first frame update
    void Start()
    {
        speed *= Time.fixedDeltaTime;
        startingPos = transform.position;
        target = new Vector3(targetX, transform.position.y, 0);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Vector3.Distance(transform.position, target) < 0.001)
        {
            newTarget = startingPos;
        }
        else if(Vector3.Distance(transform.position, startingPos) < 0.001)
        {
            newTarget = target;
        }
        transform.position = Vector3.MoveTowards(transform.position, newTarget, speed);
    }
}
