using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	GameStateManager gameStateManager;
	private GameObject[] players;
	// Use this for initialization
	void Start () {
		gameStateManager = GameStateManager.Instance;
		players = GameObject.FindGameObjectsWithTag("Player");
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
}
