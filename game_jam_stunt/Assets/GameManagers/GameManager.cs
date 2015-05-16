using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	GameStateManager gameStateManager;
	private GameObject[] players;
	// Use this for initialization
	void Start () {
		gameStateManager = GameStateManager.Instance;

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
		Debug.Log (gameStateManager.gameState);
	}

	public void activePlayers(bool active){

		foreach(GameObject player in players){

			player.GetComponent<Controle>().enabled = active;
		}
	}

	public void playerWin(int playerId){
		if (gameStateManager.gameState == GameState.Game) {

			Debug.Log("Player "+playerId+"win !");
			activePlayers(false);
			gameStateManager.gameState = GameState.End;
		}
	}
}
