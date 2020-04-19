/*
 GolfBall.cs
 By Liam Binford
 Last Edited 4/18/20
 This is the script for firing the golf balls rapidly in an arc
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GolfBall : MonoBehaviour
{
    Vector2 direction = new Vector2(-1, 1).normalized;
    public float magnitude;
    Rigidbody2D myRb;
    float time = 0;

    // Start is called before the first frame update
    void Start()
    {
        //set myRb tp the ball's rigidbody
        myRb = GetComponent<Rigidbody2D>();
        //apply force at an upward angle to the ball
        myRb.AddRelativeForce(direction * magnitude, ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        time += Time.fixedDeltaTime;
        StartCoroutine(Despawn());
    }

    IEnumerator Despawn()
    {
        //after 5 seconds, destroy the object holding this script
        while (time < 5)
        {
            yield return new WaitForFixedUpdate();
        }
        Destroy(gameObject);
    }
}
