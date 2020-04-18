using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
	protected bool isEnabled = true;

	public void enable() {
		isEnabled = true;
	}

	public void disable() {
		isEnabled = false;
	}

	// Start is called before the first frame update
	void Start() {
	}

	void FixedUpdate() {
	}
}
