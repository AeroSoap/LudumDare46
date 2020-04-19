using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Josh

public class CameraFollow : MonoBehaviour { 

	public GameObject Target;
	public float Speed;
	public float VelocityWeight;

	Transform trans;
	Rigidbody2D rb;

	void Start() {
		trans = Target.GetComponent<Transform>();
		rb = Target.GetComponent<Rigidbody2D>();
		Speed *= Time.fixedDeltaTime;
		transform.position = new Vector3(trans.position.x, trans.position.y, transform.position.z);
	}

	void FixedUpdate() {
		Vector3 move = (trans.position + new Vector3(rb.velocity.x * VelocityWeight, rb.velocity.y * VelocityWeight, 0) - new Vector3(transform.position.x, transform.position.y, 0));
		move *= Speed;
		transform.position += move;
	}
}
