﻿using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	public GameObject endScreenCanvas;
	public GameObject introCanvas;
	GameStateManager gameStateManager;
	public Goal goal;
	private GameObject[] players;
	private GameObject obstacleGenerator;

	// Use this for initialization
	void Start () {
		obstacleGenerator = GameObject.Find("ObstacleGenerator");
		gameStateManager = GameStateManager.Instance;
		gameStateManager.gameState = GameState.Intro;
		stopObstacles(true);
	}
	
	IEnumerator waitAndStart(float waitTime) {
		yield return new WaitForSeconds(waitTime);
		gameStateManager.gameState = GameState.Game;
	}
	
	// Update is called once per frame
	void Update () {
		//mise à jour des players
		players = GameObject.FindGameObjectsWithTag("Player");

		if(gameStateManager.gameState == GameState.Intro){
			if(Input.GetButtonDown("A1") || Input.GetButtonDown("A2") || Input.GetButtonDown("A3") || Input.GetButtonDown("A4")){
				introCanvas.gameObject.SetActive(false);
				stopObstacles(false);
				StartCoroutine (waitAndStart (1));
			}
		}
		
		if (Input.GetKeyDown(KeyCode.Escape)) {
			if(gameStateManager.gameState != GameState.Pause){
				gameStateManager.gameState = GameState.Pause;
				activePlayers(false);
			}else{
				gameStateManager.gameState = GameState.Game;
				activePlayers(true);
			}
		}
		
		//Debug.Log (gameStateManager.gameState);
	}
	
	public void activePlayers(bool active){
		
		foreach(GameObject player in players){
			
			player.GetComponent<Controle>().enabled = active;
			player.GetComponent<Rigidbody2D>().isKinematic = true;
		}
	}
	
	public void stopObstacles(bool active){
		//désactive le générateur d'obstacle
		obstacleGenerator.SetActive(!active);
		//stop les obstacles
		GameObject[] obstacles = GameObject.FindGameObjectsWithTag("Obstacle");
		foreach(GameObject obstacle in obstacles){
			obstacle.GetComponent<Rigidbody2D>().isKinematic = active;
		}
		
		//stop les bonus
		GameObject[] bonus = GameObject.FindGameObjectsWithTag("Bonus");
		foreach(GameObject b in bonus){
			b.GetComponent<Rigidbody2D>().isKinematic =active;
		}
		//Exception pour la barre de rocher
		GameObject.Find("barrePhare").GetComponent<Rigidbody2D>().isKinematic = true;
	}
	
	public void endScreen(string winner){
		Debug.Log ("endscreen");
		endScreenCanvas.GetComponent<EndScreen>().winner = winner;
		endScreenCanvas.GetComponent<EndScreen>().activeScreen();
		endScreenCanvas.SetActive(true);
	}
	
	public void playerWin(GameObject player,GameObject objectif){
		if (gameStateManager.gameState == GameState.Game) {
			bool win = goal.goal(player,objectif);
			Debug.Log ("Player Win ? : "+win);
			int playerId = player.GetComponent<Controle>().playerId;
			if(win){
				activePlayers(false);
				stopObstacles(true);
				if(playerId==1) endScreen("Rouge");
				if(playerId==2) endScreen("Vert");
				if(playerId==3) endScreen("Jaune");
				if(playerId==4) endScreen("Orange");
				gameStateManager.gameState = GameState.End;
			}else{
				Debug.Log ("Joueur "+playerId+" marque 1 point");
			}
		}
	}
	
}
