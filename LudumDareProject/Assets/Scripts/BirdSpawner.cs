using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Josh

public class BirdSpawner : MonoBehaviour {

	public GameObject Bird;
	public float MinY;
	public float MaxY;
	public float SpawnX;
	public float DespawnX;
	public float SpawnRate;

	// Start is called before the first frame update
	void Start() {
		
	}

	void FixedUpdate() {
		// A random chance to spawn a bird each frame, average SpawnRate per second
		if(Random.value < Time.fixedDeltaTime * SpawnRate) {
			Instantiate(Bird, new Vector3(SpawnX, Random.Range(MinY, MaxY), 0), Quaternion.identity)
				.GetComponent<Bird>().SetDespawn(DespawnX);
		}
	}
}
