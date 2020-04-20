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
    public float DespawnTime = 3;

    Vector2 direction = new Vector2(-1, 1).normalized;
    public int magnitude;
    Rigidbody2D myRb;
    float time = 0;
    public bool isRandom;

    // Start is called before the first frame update
    void Start()
    {
        if (isRandom)
        {
            magnitude = Random.Range(10, 30);
        }
        //set myRb tp the ball's rigidbody
        myRb = GetComponent<Rigidbody2D>();
        //apply force at an upward angle to the ball
        myRb.AddRelativeForce(direction * magnitude, ForceMode2D.Impulse);
        //set magnitude to a random number between 15 and 25

        StartCoroutine(Despawn());
    }


    IEnumerator Despawn()
    {
        yield return new WaitForSeconds(DespawnTime);
        Destroy(gameObject);
    }
}
