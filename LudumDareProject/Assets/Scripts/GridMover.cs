using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Josh

public class GridMover : MonoBehaviour {

	public float ScaleX;
	public float ScaleY;
	GameObject cam;
	Vector2 pos;

	public void Init(int x, int y, GameObject cam) {
		pos = new Vector2(x, y);
		this.cam = cam;
	}

	// Start is called before the first frame update
	void Start() {
		
	}

	// Update is called once per frame
	void Update() {
		Vector2 camPos = cam.transform.position;
		// Rounding
		camPos = new Vector2((int) (camPos.x / ScaleX), (int) (camPos.y / ScaleY));
		camPos = new Vector2(camPos.x * ScaleX, camPos.y * ScaleY);
		Vector2 offset = new Vector2(pos.x * ScaleX, pos.y * ScaleY);
		transform.position = camPos + offset;
	}
}
