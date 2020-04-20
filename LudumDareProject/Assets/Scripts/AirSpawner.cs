using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Josh

public class AirSpawner : MonoBehaviour {

	public int AirParticles = 100;
	public float Lifespan = 5;
	public GameObject AirParticle;
	public GameObject Player;

	int curActive = 0;

	void Start() {
		
	}

	void FixedUpdate() {
		for(int i = 0; i < AirParticles - curActive; i++) {
			Vector3 pos = new Vector2(Random.Range(-15.83f, 15.83f), Random.Range(-10, 10));
			GameObject particle = Instantiate(AirParticle, Player.transform.position + pos, Quaternion.identity);
			curActive++;
			StartCoroutine(DestroyParticle(particle));
		}
	}

	IEnumerator DestroyParticle(GameObject particle) {
		yield return new WaitForSeconds(Lifespan * Random.Range(0.5f, 1.5f));
		curActive--;
		Destroy(particle);
	}

}
