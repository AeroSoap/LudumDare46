using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Josh
public class Crush : MonoBehaviour {

	static int curCrushing;

	void Start() {
		curCrushing = 0;
	}

	private void OnCollisionEnter2D(Collision2D col) {
		Health health = col.gameObject.GetComponent<Health>();
		if(health != null) {
			curCrushing++;
			if(curCrushing > 1) {
				health.hurt(1e9f);
			}
		}
	}

	private void OnCollisionExit2D(Collision2D col) {
		Health health = col.gameObject.GetComponent<Health>();
		if(health != null) {
			curCrushing--;
		}
	}
}
