using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProximityMine : MonoBehaviour {

	public GameObject Player;
	public Sprite ActiveSprite;
	public Sprite ExplosionSprite;
	public float ActivationRadius;
	public float ActivationTime;
	public float ExplosionTime;
	public float ExplosionForce;
	public float ExplosionDamage;

	bool isActive;
	SpriteRenderer sr;

	// Start is called before the first frame update
	void Start() {
		sr = GetComponent<SpriteRenderer>();
	}

	bool canSeePlayer() {
		Vector2 dir = Player.transform.position - transform.position;
		RaycastHit2D hit = Physics2D.Raycast(transform.position, dir);
		return hit.collider.gameObject.GetComponent<Health>() != null;
	}

	void FixedUpdate() {
		if(!isActive && (transform.position - Player.transform.position).magnitude < ActivationRadius) {
			if(canSeePlayer()) {
				isActive = true;
				StartCoroutine(Trigger());
			}
		}
	}

	IEnumerator Trigger() {
		sr.sprite = ActiveSprite;
		yield return new WaitForSeconds(ActivationTime);
		sr.sprite = ExplosionSprite;
		if(canSeePlayer()) {
			Rigidbody2D prb = Player.GetComponent<Rigidbody2D>();
			Health health = Player.GetComponent<Health>();
			Vector2 rel = (Player.transform.position - transform.position);
			float dist = rel.magnitude;
			rel = rel.normalized;
			dist++;
			prb.AddForce(rel / (dist * dist) * ExplosionForce);
			health.hurt(ExplosionDamage / (dist * dist));
		}
		yield return new WaitForSeconds(ExplosionTime);
		Destroy(gameObject);
	}
}
