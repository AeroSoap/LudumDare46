using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneControl : Control
{
	public string MoveLeft = "a";
	public string MoveRight = "d";
	public float MovementForce = 10;

	public GameObject LeftProp;
	public GameObject RightProp;

	Rigidbody2D rb;

	// Start is called before the first frame update
	void Start() {
		rb = GetComponent<Rigidbody2D>();
		MovementForce *= Time.fixedDeltaTime;
	}

	void FixedUpdate() {
		if(!isEnabled) return;
		Vector2 dir = new Vector2();
		dir.x = Mathf.Cos(Mathf.Deg2Rad * (transform.eulerAngles.z + 90));
		dir.y = Mathf.Sin(Mathf.Deg2Rad * (transform.eulerAngles.z + 90));
		if(Input.GetKey(MoveLeft)) {
			rb.AddForceAtPosition(dir * MovementForce, RightProp.transform.position);
		}
		if(Input.GetKey(MoveRight)) {
			rb.AddForceAtPosition(dir * MovementForce, LeftProp.transform.position);
		}

		if(transform.eulerAngles.z > 30 && transform.eulerAngles.z < 180)
		{
			rb.AddForceAtPosition(dir * MovementForce, LeftProp.transform.position);
		}

		if (transform.eulerAngles.z < 330 && transform.eulerAngles.z > 180)
		{
			rb.AddForceAtPosition(dir * MovementForce, RightProp.transform.position);
		}
	}
}
