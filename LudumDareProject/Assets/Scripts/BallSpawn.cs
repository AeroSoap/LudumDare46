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
    public float xOffest;
    public float yOffest;
    Vector3 spawnPos;
    public GameObject SpawnedObject;
    public float time;

    // Start is called before the first frame update
    void Start()
    {
        spawnPos = new Vector3(transform.position.x + xOffest, transform.position.y + yOffest, 0);
        StartCoroutine(Spawn());
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }

    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(time);
        Instantiate(SpawnedObject, spawnPos, Quaternion.identity);
        StartCoroutine(Spawn());
    }
}
