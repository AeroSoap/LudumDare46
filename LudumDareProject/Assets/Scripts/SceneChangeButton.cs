using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Josh

public class SceneChangeButton : MonoBehaviour {
	public string TargetScene;
	public Sprite HoverSprite;

	SpriteRenderer sr;
	Sprite defaultSprite;

	void Start() {
		sr = GetComponent<SpriteRenderer>();
		defaultSprite = sr.sprite;
	}

	void Update() {
		
	}

	private void OnMouseDown() {
		SceneManager.LoadScene(TargetScene);
	}

	private void OnMouseEnter() {
		sr.sprite = HoverSprite;
	}

	private void OnMouseExit() {
		sr.sprite = defaultSprite;
	}
}
