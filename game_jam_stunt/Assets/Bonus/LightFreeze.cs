using UnityEngine;
using System.Collections;

public class LightFreeze : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameObject.Find ("Phare").GetComponent<Animator>().speed = 0;
		StartCoroutine (waitAndRestartPhare (5));
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
