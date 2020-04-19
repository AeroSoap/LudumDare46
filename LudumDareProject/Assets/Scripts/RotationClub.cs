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
    Vector3 backwards = new Vector3(0, 0, -4);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Rotate(backwards);
    }
}
