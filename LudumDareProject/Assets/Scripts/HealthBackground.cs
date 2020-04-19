using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBackground : MonoBehaviour {

	public Vector3 Offset;

	[HideInInspector]
	public GameObject Vehicle;
	[HideInInspector]
	public Health Health;

	// Update is called once per frame
	void Update() {
		transform.position = Vehicle.transform.position + Offset;
		transform.rotation = Quaternion.identity;
	}
}
