using UnityEngine;
using System.Collections;

public class Grappin : MonoBehaviour {

	float maxDistance = 1000;
	float speed = 6;

	int idPlayer;
	Vector2 target, start;
	float distance;
	float startTime;
	bool grap = false;

	void initGrappin(GameObject player){
		//getComponent comme dans end.cs
		idPlayer = player.GetComponent<Controle>().playerId;
	}

	// Use this for initialization
	void Start () {
		startTime = Time.time;
		start = this.gameObject.transform.position;

		RaycastHit2D hit = Physics2D.Raycast(this.gameObject.transform.position, new Vector3(0, 1, 0), maxDistance);
		if(hit.collider != null){
			target = hit.point;
			distance = hit.distance;
			grap = true;
			Debug.Log("Target : " + hit.transform.name);
		}

	}
	
	// Update is called once per frame
	void Update () {
		if(grap){
			Debug.Log("Grap : " + grap);
			float increment = ((Time.time - startTime)/distance)*speed;
			this.gameObject.transform.position = Vector2.Lerp(start, target, increment);
			if(Mathf.Abs(this.gameObject.transform.position.y-target.y)<=0.1) grap = false;
		}
		if (Input.GetButtonDown("A"+(idPlayer+1))) {
			grap = false;
		}
	}

	void OnCollisionEnter2D(Collision2D c){
		grap = false;
	}
}
