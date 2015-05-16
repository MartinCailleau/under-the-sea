using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	GameStateManager gameStateManager;
	private GameObject[] players;
	// Use this for initialization
	void Start () {
		gameStateManager = GameStateManager.Instance;
		players = GameObject.FindGameObjectsWithTag("Player");
		gameStateManager.gameState = GameState.Game;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape)) {
			if(gameStateManager.gameState != GameState.Pause){
				gameStateManager.gameState = GameState.Pause;
				activePlayers(false);
			}else{
				gameStateManager.gameState = GameState.Game;
				activePlayers(true);
			}
		}
	}

	public void activePlayers(bool active){
		foreach(GameObject player in players){
			player.GetComponent<Controle>().enabled = active;
		}
	}

	public void playerWin(int playerId){
		Debug.Log (playerId);
		if (gameStateManager.gameState == GameState.Game) {
			gameStateManager.gameState = GameState.End;
			Debug.Log("Player "+playerId+"win !");
			activePlayers(false);
		}
	}
}
