using UnityEngine;
using System.Collections;

public class LightFreeze : MonoBehaviour {
	public int time = 2;
	// Use this for initialization
	void Start () {
		GameObject.Find ("Phare").GetComponent<Animator>().speed = 0;
		StartCoroutine (waitAndRestartPhare (time));
	}
	
	// Update is called once per frame
	void Update () {

	}


	IEnumerator waitAndRestartPhare(float waitTime) {
		yield return new WaitForSeconds(waitTime);
		GameObject.Find ("Phare").GetComponent<Animator>().speed = 1;
		Destroy (this);
	}
}
