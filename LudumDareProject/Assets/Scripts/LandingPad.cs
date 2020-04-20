using UnityEngine;
using UnityEngine.SceneManagement;

// Josh

public class LandingPad : MonoBehaviour {

	public string NextScene;
	public float LandTime = 3;

	float timer = float.MaxValue;

	private void FixedUpdate() {
		if(timer <= 0) {
			SceneManager.LoadScene(NextScene);
		} else {
			timer -= Time.fixedDeltaTime;
		}
	}

	private void OnCollisionEnter2D(Collision2D col) {
		if(col.gameObject.GetComponent<Health>() != null) {
			timer = LandTime;
		}
	}

	private void OnCollisionExit2D(Collision2D col) {
		if(col.gameObject.GetComponent<Health>() != null) {
			timer = float.MaxValue;
		}
	}
}
