using UnityEngine;
using System.Collections;

public class Bumper : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerStay2D(Collider2D collider){
		if (collider.gameObject.tag == "Player" && collider.gameObject.transform != gameObject.transform.parent) {
			Debug.Log(collider.gameObject.name);
			Vector3 direction = (collider.gameObject.transform.position)-gameObject.transform.position;

			Debug.Log(direction);
			float wearoff = 1 - (direction.magnitude / 10);
			collider.gameObject.GetComponent<Rigidbody2D>().AddForce(direction.normalized * 5000 * wearoff);
			Destroy(gameObject);
		}
	}
}
