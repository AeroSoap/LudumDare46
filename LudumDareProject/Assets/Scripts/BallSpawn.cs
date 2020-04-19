/*
 BallSpawn.cs
 By Liam Binford
 Last Edited 4/18/20
 Golf ball spawn
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawn : MonoBehaviour
{
    public float xPos;
    public float yPos;
    Vector3 spawnPos;
    public GameObject SpawnedObject;

    // Start is called before the first frame update
    void Start()
    {
        spawnPos = new Vector3(transform.position.x - 1, transform.position.y - 2, 0);
        StartCoroutine(Spawn());
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }

    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(0.5f);
        Instantiate(SpawnedObject, spawnPos, Quaternion.identity);
        StartCoroutine(Spawn());
    }
}
