using UnityEngine;
using System.Collections;

public class RespawnPlayer : MonoBehaviour {

	GameObject respawnPoint;

	void Start(){
		respawnPoint = GameObject.Find("spawn1");
	}

	void OnCollisionEnter2D(Collision2D c){

		if(c.gameObject.tag=="Obstacle"){
			this.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0,0);
			this.gameObject.transform.position = respawnPoint.transform.position;
		}
	}
}
