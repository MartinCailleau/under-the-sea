﻿using UnityEngine;
using System.Collections;

public class ObstacleBehavior : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D c){
		if(c.gameObject.tag=="Player"){
			this.detroyObstacle();
		}
	}

	public void detroyObstacle(){
		Destroy (gameObject);
	}
}
