using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Josh

public class ContactDamage : MonoBehaviour {
	public float Damage;

	public void OnTriggerEnter2D(Collider2D col) {
		Health health = col.gameObject.GetComponent<Health>();
		if(health != null) {
			health.hurt(Damage);
		}
	}
}
