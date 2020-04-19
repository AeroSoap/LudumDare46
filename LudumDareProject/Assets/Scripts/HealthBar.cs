using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Josh

public class HealthBar : MonoBehaviour {

	public Vector3 Offset;

	[HideInInspector]
	public GameObject Vehicle;
	[HideInInspector]
	public Health Health;

	// Update is called once per frame
	void Update() {
		transform.localScale = new Vector3(Health.health, transform.localScale.y, transform.localScale.z);
		transform.position = Vehicle.transform.position + Offset - new Vector3((1 - Health.health) / 2, 0, 0);
		transform.rotation = Quaternion.identity;
	}
}
