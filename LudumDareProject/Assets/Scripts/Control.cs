using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour {

	protected bool isEnabled = false;
	SpriteRenderer sr;

	void Awake() {
		sr = GetComponent<SpriteRenderer>();
	}

	public void enable() {
		isEnabled = true;
		sr.color = new Vector4(1, 1, 0.75f, 1);
	}

	public void disable() {
		isEnabled = false;
		sr.color = new Vector4(1, 1, 1, 1);
	}

	private void OnMouseDown() {
		Hacker.hack(this);
	}
}
