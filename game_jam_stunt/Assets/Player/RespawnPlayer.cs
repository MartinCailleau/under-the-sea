using UnityEngine;
using System.Collections;

public class RespawnPlayer : MonoBehaviour {

	GameObject respawnPoint;

	void Start(){

		respawnPoint = GameObject.Find("spawn"+gameObject.GetComponent<Controle>().playerId	);
	}

	void OnCollisionEnter2D(Collision2D c){

		if(c.gameObject.tag=="Obstacle"){

			StartCoroutine(waitAndRespawn(1));
		

		}
	}

	IEnumerator waitAndRespawn(float waitTime) {
		this.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0,0);
		this.gameObject.transform.position = respawnPoint.transform.position;
		this.gameObject.GetComponent<Animator> ().SetBool ("blink", true);
		this.gameObject.GetComponent<Controle> ().enabled=false;

		yield return new WaitForSeconds(waitTime);
		this.gameObject.GetComponent<Animator> ().SetBool ("blink", false);
		this.gameObject.GetComponent<Controle>().enabled=true;

	}
}
