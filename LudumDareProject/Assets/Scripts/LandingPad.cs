using UnityEngine;
using UnityEngine.SceneManagement;

public class LandingPad : MonoBehaviour
{
	public string NextScene;

	private void OnTriggerEnter2D(Collider2D col) {
		if(col.gameObject.GetComponent<Health>() != null) {
			SceneManager.LoadScene(NextScene);
		}
	}
}
