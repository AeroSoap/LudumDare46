using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Josh

public class Health : MonoBehaviour {

	public float Armor = 1;
	public float DeathTime = 1.5f;
	public GameObject HealthBar;
	public GameObject HealthBackground;
	HealthBar healthBar;
	HealthBackground healthBg;

	[HideInInspector]
	public float health = 1;

	// Start is called before the first frame update
	void Start() {
		healthBar = Instantiate(HealthBar, transform).GetComponent<HealthBar>();
		healthBar.Vehicle = gameObject;
		healthBar.Health = this;
		healthBg = Instantiate(HealthBackground, transform).GetComponent<HealthBackground>();
		healthBg.Vehicle = gameObject;
		healthBg.Health = this;
	}

	private void OnCollisionEnter2D(Collision2D col) {
		float hitForce = col.relativeVelocity.magnitude;
		if(col.rigidbody == null) {
			hitForce *= col.otherRigidbody.mass;
		} else {
			hitForce *= Mathf.Min(col.rigidbody.mass, col.otherRigidbody.mass);
		}
		if(hitForce > 5) {
			hurt(hitForce);
		}
	}

	public void hurt(float amt) {
		amt /= Armor;
		health -= amt;
		if(health <= 0) {
			health = 0;
			StartCoroutine(kill());
		}
	}

	IEnumerator kill() {
		yield return new WaitForSeconds(DeathTime);
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
}
