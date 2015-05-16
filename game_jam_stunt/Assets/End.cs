﻿using UnityEngine;
using System.Collections;

public class End : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D collider){
		if (collider.gameObject.tag == "Player") {
			GameStateManager.Instance.gameState = GameState.End;

			int playerId = collider.gameObject.GetComponent<Controle>().playerId;
			Debug.Log("Player "+playerId+" win!");
		}
	}
}
