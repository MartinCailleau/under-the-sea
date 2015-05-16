using UnityEngine;
using System.Collections;

public class IEM : MonoBehaviour {

	public int time = 2;
	public GameObject[] players;
	public GameObject playerLauncher;

	void Awake () {

	}

	public void initIEM(int time,GameObject player){
		this.time = time;
		playerLauncher = player;
		players = GameObject.FindGameObjectsWithTag("Player");
		foreach(GameObject p in players){
			p.GetComponentInChildren<Light>().enabled = false;
		}
		playerLauncher.GetComponentInChildren<Light> ().enabled = true;
		StartCoroutine (waitAndRestart(time));
	}
	
	IEnumerator waitAndRestart(float waitTime) {
		yield return new WaitForSeconds(waitTime);
		foreach(GameObject player in players){
			player.GetComponentInChildren<Light>().enabled = true;
		}
		Destroy (this);
	}
}
