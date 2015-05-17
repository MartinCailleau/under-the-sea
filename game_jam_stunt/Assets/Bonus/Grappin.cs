using UnityEngine;
using System.Collections;

public class Grappin : MonoBehaviour {

	float maxDistance = 100;

	Vector2 target, start;
	float distance;
	float startTime;
	bool grap = false;

	// Use this for initialization
	void Start () {
		Debug.Log("GRAPPIN");
		startTime = Time.time;
		start = this.gameObject.transform.position;

		RaycastHit2D hit = Physics2D.Raycast(this.gameObject.transform.position, new Vector3(0, 1, 0), maxDistance);
		if(hit.collider != null){
			target = hit.point;
			distance = hit.distance;
			grap = true;
		}

	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log ("Grap " + grap);
		if(grap){
			float increment = (Time.time - startTime)/distance;
			this.gameObject.transform.position = Vector2.Lerp(start, target, increment);
			if(Mathf.Abs(this.gameObject.transform.position.y-target.y)<=1) grap = false;
		}
	}
}
