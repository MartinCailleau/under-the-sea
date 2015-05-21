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
			foreach(Light light in p.GetComponentsInChildren<Light>()){
				light.enabled = false;
			}
		}
		foreach(Light light in playerLauncher.GetComponentsInChildren<Light>()){
			light.enabled = true;
			light.intensity = 8;

		}

		StartCoroutine (waitAndRestart(time));
	}
	
	IEnumerator waitAndRestart(float waitTime) {
		yield return new WaitForSeconds(waitTime);
		foreach(GameObject p in players){
			foreach(Light light in p.GetComponentsInChildren<Light>()){
				light.enabled = true;
				light.intensity = 7;
			}
		}
		Destroy (this);
	}
}
