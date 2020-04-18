using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {

	public static float HackCooldown = 1.25f;

	static Control curHacked;
	static float prevTime = -HackCooldown;

	public static void hack(Control control) {
		if(Time.time - prevTime >= HackCooldown) {
			prevTime = Time.time;
			if(curHacked != null) {
				curHacked.disable();
			}
			control.enable();
			curHacked = control;
		}
	}
}
