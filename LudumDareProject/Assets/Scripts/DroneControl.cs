using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Josh

public class DroneControl : MonoBehaviour {

	public string MoveLeft;
	public string MoveRight;
	public float MovementForce;
	public float CorrectionStrength;

	public GameObject LeftProp;
	public GameObject RightProp;

	Rigidbody2D rb;

	bool onGround = false;

	// Start is called before the first frame update
	void Start() {
		rb = GetComponent<Rigidbody2D>();
		MovementForce *= Time.fixedDeltaTime;
	}

	private void OnCollisionEnter2D(Collision2D col) {
		onGround = true;
	}

	private void OnCollisionExit2D(Collision2D col) {
		onGround = false;
	}

	void FixedUpdate() {
		if(GetComponent<Health>().health > 0) {
			Vector2 dir = new Vector2();
			dir.x = Mathf.Cos(Mathf.Deg2Rad * (transform.eulerAngles.z + 90));
			dir.y = Mathf.Sin(Mathf.Deg2Rad * (transform.eulerAngles.z + 90));
			if(!onGround) {
				if(transform.eulerAngles.z > 30 && transform.eulerAngles.z < 180) {
					float dif = (transform.eulerAngles.z - 30) * Time.fixedDeltaTime;
					rb.AddForceAtPosition(dir * Mathf.Min(MovementForce, dif * CorrectionStrength), LeftProp.transform.position);
				}

				if(transform.eulerAngles.z < 330 && transform.eulerAngles.z > 180) {
					float dif = (330 - transform.eulerAngles.z) * Time.fixedDeltaTime;
					rb.AddForceAtPosition(dir * Mathf.Min(MovementForce, dif * CorrectionStrength), RightProp.transform.position);
				}
			}
			if(Input.GetKey(MoveLeft)) {
				rb.AddForceAtPosition(dir * MovementForce, RightProp.transform.position);
			}
			if(Input.GetKey(MoveRight)) {
				rb.AddForceAtPosition(dir * MovementForce, LeftProp.transform.position);
			}
		}
	}
}
