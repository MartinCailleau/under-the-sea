using UnityEngine;
using System.Collections;

public class End : MonoBehaviour {
	public GameObject gameManager;
	// Use this for initialization
	void Start () {
		gameManager = GameObject.Find ("GameManager");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D collider){
		if (collider.gameObject.tag == "Player") {
			int playerId = collider.gameObject.GetComponent<Controle>().playerId;
			gameManager.GetComponent<GameManager>().playerWin(playerId);
		}
	}
}
