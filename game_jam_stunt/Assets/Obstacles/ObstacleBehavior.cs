using UnityEngine;
using System.Collections;

public class ObstacleBehavior : MonoBehaviour {
	public GameObject boom;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D c){
		if(c.gameObject.tag=="Player"){
			this.detroyObstacle();
		}
	}

	public void detroyObstacle(){
		GameObject go = Instantiate(boom,gameObject.transform.position,gameObject.transform.rotation) as GameObject;
		Destroy (gameObject);
	}
}
