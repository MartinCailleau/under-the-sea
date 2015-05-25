using UnityEngine;
using System.Collections;

public class Objectif : MonoBehaviour {
	GameObject gameManager;
	public int idObjectif;
	// Use this for initialization
	void Start () {
		gameManager = GameObject.Find ("GameManager");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D collider){
		if (collider.gameObject.tag == "Player") {
			gameManager.GetComponent<GameManager>().playerWin(collider.gameObject,gameObject);
		}
	}
}
