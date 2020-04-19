﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Josh

public class StormCloud : MonoBehaviour
{
	public float Interval;
	public float LightningTime;
	public GameObject Lightning;

	GameObject lightning;

	// Start is called before the first frame update
	void Start() {
		StartCoroutine(InitializeCloud());
	}

	IEnumerator InitializeCloud() {
		yield return new WaitForSeconds(Random.value * Interval);
		StartCoroutine(LightningSpawn());
	}

	IEnumerator LightningDestroy() {
		yield return new WaitForSeconds(LightningTime);
		Destroy(lightning);
	}

	IEnumerator LightningSpawn() {
		yield return new WaitForSeconds(Interval);
		lightning = Instantiate(Lightning, transform.position + new Vector3(0, -50), Quaternion.identity);
		StartCoroutine(LightningSpawn());
		StartCoroutine(LightningDestroy());
	}
}
