using UnityEngine;
using System.Collections;

public class safezone : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D collider){
		Debug.Log (collider.gameObject);
		if (collider.gameObject.tag == "Obstacle") {
			GameObject.Destroy(collider.gameObject);
		}
	}
}
