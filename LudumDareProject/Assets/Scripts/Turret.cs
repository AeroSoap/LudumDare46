using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Josh

public class Turret : MonoBehaviour {

	public GameObject Laser;
	public GameObject Bullet;
	public float LaunchForce = 10000;

	GameObject laser;

	// Start is called before the first frame update
	void Start() {
		laser = Instantiate(Laser, transform.position, transform.rotation);
		laser.transform.parent = transform;
	}

	void FixedUpdate() {
		float length = 3;
		int mask = ~(1 << 8);
		Vector3 dir = transform.TransformDirection(Vector3.right);
		RaycastHit2D hit = Physics2D.Raycast(transform.position, dir, 100, mask);
		if(hit.collider != null) {
			length = hit.distance;
			Health health = hit.collider.gameObject.GetComponent<Health>();
			if(health != null) {
				Rigidbody2D bullet = Instantiate(Bullet, transform.position, transform.rotation).GetComponent<Rigidbody2D>();
				bullet.AddRelativeForce(new Vector2(LaunchForce, 0));
			}
		} else {
			length = 100;
		}
		laser.transform.localScale = new Vector3(length, laser.transform.localScale.y);
		laser.transform.localPosition = new Vector3(length / 2, 0);
	}
}
