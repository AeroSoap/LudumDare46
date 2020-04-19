/*
 GopherJump.cs
 By Liam Binford
 Last Edited 4/19/20
 Gopher jumps and falls back into hole on an interval
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GopherJump : MonoBehaviour
{
    Vector2 direction = new Vector2(0, 1).normalized;
    public float magnitude;
    Rigidbody2D myRb;

    // Start is called before the first frame update
    void Start()
    {
        myRb = GetComponent<Rigidbody2D>();
        StartCoroutine(Jump());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Jump()
    {
        yield return new WaitForSeconds(5);
        myRb.AddRelativeForce(direction * magnitude, ForceMode2D.Impulse);
        StartCoroutine(Jump());
    }
}
