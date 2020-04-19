using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Josh

public class PlaneSpawner : MonoBehaviour {

	public GameObject Player;
	public GameObject Plane;
	public float MaxY;
	public float LaunchForce;

	// Start is called before the first frame update
	void Start() {

	}

	void FixedUpdate() {
		if(Player.transform.position.y >= MaxY) {
			if(Random.value < Time.fixedDeltaTime) {
				float x, y, v;
				if(Random.value < 0.5) {
					x = Player.transform.position.x - 30;
					v = LaunchForce;
				} else {
					x = Player.transform.position.x + 30;
					v = -LaunchForce;
				}
				y = Player.transform.position.y;
				GameObject plane = Instantiate(Plane, new Vector3(x, y), Quaternion.identity);
				plane.GetComponent<Rigidbody2D>().AddForce(new Vector2(v, 0));
			}
		}
	}
}
