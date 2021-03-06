﻿using UnityEngine;
using System.Collections;

public class Pipe : MonoBehaviour {
	public float minY = -0.4f;
	public float maxY = -0.1f;

	// Use this for initialization
	void Start () {
		this.RandGenPos();
	}
	
	// Update is called once per frame
	void Update () {
	
	}



	void OnGUI(){
		GUILayout.Label("Score:" + GameManager._instance.score);

	}

	public void RandGenPos(){
		float y = Random.Range(minY,maxY);
		float originX = this.transform.localPosition.x;
		float originZ = this.transform.localPosition.z;
		this.transform.localPosition = new Vector3(originX,y,originZ);
	}

	void OnTriggerEnter(Collider other) {
		if(other.tag == "Player"){
			Bird bird = other.GetComponent<Bird>();
			bird.PlayScoreAudio();
			GameManager._instance.score ++;
		}
	}

	void OnCollisionEnter(Collision collision) {
		if(collision.gameObject.tag == "Player"){
			Bird bird = collision.gameObject.GetComponent<Bird>();
			bird.PlayHitAudio();
			bird.PlayDieAudio();
			GameManager._instance.gameState = GameManager.GAMESTATE_END;
		}
	}
}
