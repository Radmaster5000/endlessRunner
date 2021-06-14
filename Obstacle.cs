﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour {

	PlayerMovement playerMovement;

	// Use this for initialization
	void Start () {
		playerMovement = GameObject.FindObjectOfType<PlayerMovement>();
		
	}

	private void OnCollisionEnter (Collision collision) {

		if (collision.gameObject.name == "Player") {
			// Kill the player
			playerMovement.Die();
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}