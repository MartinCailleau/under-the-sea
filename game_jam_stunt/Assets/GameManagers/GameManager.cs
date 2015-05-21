using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	public GameObject endScreenCanvas;
	GameStateManager gameStateManager;
	private GameObject[] players;
	// Use this for initialization
	void Start () {
		gameStateManager = GameStateManager.Instance;
		gameStateManager.gameState = GameState.Game;
		StartCoroutine (waitAndStart (2));
	}

	IEnumerator waitAndStart(float waitTime) {
		gameStateManager.gameState = GameState.Pause;
		yield return new WaitForSeconds(waitTime);
		gameStateManager.gameState = GameState.Game;
	}

	// Update is called once per frame
	void Update () {
		players = GameObject.FindGameObjectsWithTag("Player");
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
		}
	}

	public void stopObstacles(){
		//désactive le générateur d'obstacle
		GameObject.Find("ObstacleGenerator").SetActive(false);
		//stop les obstacles
		GameObject[] obstacles = GameObject.FindGameObjectsWithTag("Obstacle");
		foreach(GameObject obstacle in obstacles){
			obstacle.GetComponent<Rigidbody2D>().isKinematic = true;
		}

		//stop les bonus
		GameObject[] bonus = GameObject.FindGameObjectsWithTag("Bonus");
		foreach(GameObject b in bonus){
			b.GetComponent<Rigidbody2D>().isKinematic = true;
		}
	}

	public void endScreen(string winner){
		Debug.Log ("endscreen");
		endScreenCanvas.GetComponent<EndScreen>().winner = winner;
		endScreenCanvas.GetComponent<EndScreen>().activeScreen();
		endScreenCanvas.SetActive(true);
	}

	public void playerWin(int playerId){
		if (gameStateManager.gameState == GameState.Game) {

			Debug.Log("Player "+playerId+"win !");
			activePlayers(false);
			stopObstacles();
			if(playerId==1) endScreen("Rouge");
			if(playerId==2) endScreen("Vert");
			if(playerId==3) endScreen("Jaune");
			if(playerId==4) endScreen("Orange");
			
			gameStateManager.gameState = GameState.End;
		}
	}
	
}
