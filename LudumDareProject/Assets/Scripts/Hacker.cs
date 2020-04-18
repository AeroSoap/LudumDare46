using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {

	static Control curHacked;

	public static void hack(Control control) {
		if(curHacked != null) {
			curHacked.disable();
		}
		control.enable();
		curHacked = control;
	}
}
