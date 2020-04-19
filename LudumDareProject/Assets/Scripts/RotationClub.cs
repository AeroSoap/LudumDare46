/*
 RotationClub.cs
 By Liam Binford
 4/18/20
 CLUB GO ZOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOM!!!
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationClub : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Rotate(Vector3.back);
    }
}
