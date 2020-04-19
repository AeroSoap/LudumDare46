using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Josh

public class Bird : MonoBehaviour {

    public float Acceleration;
    public Sprite OtherSprite;

    Rigidbody2D rb;
    float despawnX;
    SpriteRenderer sr;

    public void SetDespawn(float x) {
        despawnX = x;
    }

    void Start() {
        rb = GetComponent<Rigidbody2D>();
        Acceleration *= Time.fixedDeltaTime;
        sr = GetComponent<SpriteRenderer>();
    }

    void FixedUpdate() {
        Vector3 move = transform.rotation * Vector3.left * Acceleration;
        rb.AddForce(move);
        if(transform.position.x < despawnX) {
            Destroy(gameObject);
        }
    }

    private void Update() {
        Sprite temp = sr.sprite;
        sr.sprite = OtherSprite;
        OtherSprite = temp;
    }
}
