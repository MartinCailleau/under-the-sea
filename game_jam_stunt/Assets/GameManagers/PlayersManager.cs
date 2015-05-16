using UnityEngine;
using System.Collections;

public class PlayersManager : MonoBehaviour {
	public GameObject prefabPlayer1;
	public GameObject prefabPlayer2;
	public GameObject prefabPlayer3;
	public GameObject prefabPlayer4;
	public GameObject spawn1;
	public GameObject spawn2;
	public GameObject spawn3;
	public GameObject spawn4;
	public bool[] playerOn;
	// Use this for initialization
	void Start () {
		playerOn = new bool[4];
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("A1")) {
			if(!playerOn[0]){
				GameObject player = Instantiate(prefabPlayer1,spawn1.transform.position,Quaternion.identity) as GameObject;
				player.gameObject.name = "player1";
				player.GetComponent<Controle>().playerId = 1;
				//Rouge
				playerOn[0] = true;
			}
		}
		if (Input.GetButtonDown("A2")) {
			if(!playerOn[1]){
				GameObject player = Instantiate(prefabPlayer2,spawn2.transform.position,Quaternion.identity) as GameObject;
				player.gameObject.name = "player2";
				player.GetComponent<Controle>().playerId = 2;
				//Vert
				playerOn[1] = true;
			}
		}
		if (Input.GetButtonDown("A3")) {
			if(!playerOn[2]){
				GameObject player = Instantiate(prefabPlayer3,spawn3.transform.position,Quaternion.identity) as GameObject;
				player.gameObject.name = "player3";
				player.GetComponent<Controle>().playerId = 3;
				//Jaune
				playerOn[2] = true;
			}
		}
		if (Input.GetButtonDown("A4")) {
			if(!playerOn[3]){
				GameObject player = Instantiate(prefabPlayer4,spawn4.transform.position,Quaternion.identity) as GameObject;
				player.gameObject.name = "player4";
				player.GetComponent<Controle>().playerId = 4;
				//Orange
				playerOn[3] = true;
			}
		}
	}
}
