﻿using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {

	public float speed = 50f;
	public float jump = 150f;
	public float maxSpeed = 3;
	private Rigidbody2D RB2;
	// Use this for initialization
	void Start () {
		RB2 = gameObject.GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate(){
		float move = Input.GetAxis ("Horizontal");
		RB2.AddForce ((Vector2.right * speed) *move);

		if (RB2.velocity.x > maxSpeed) {
			RB2.velocity = new Vector2 (maxSpeed, RB2.velocity.y);
		}

		if (RB2.velocity.x < -maxSpeed) {
			RB2.velocity = new Vector2 (-maxSpeed, RB2.velocity.y);
		}
	}
}