using UnityEngine;
using System.Collections;

public class Bumper : MonoBehaviour {
	public GameObject shockwave; 
	// Use this for initialization
	void Start () {
		StartCoroutine (waitAndDetroy (0.5f));
	}

	IEnumerator waitAndDetroy(float waitTime) {
		GameObject go = Instantiate(shockwave,gameObject.transform.position,gameObject.transform.rotation) as GameObject;
		go.transform.parent = gameObject.transform;
		yield return new WaitForSeconds(waitTime);
		Destroy (go);
		Destroy (gameObject);
	}

	void OnTriggerStay2D(Collider2D collider){
		if (collider.gameObject.tag == "Player" && collider.gameObject.transform != gameObject.transform.parent) {
			Debug.Log(collider.gameObject.name);
			Vector3 direction = (collider.gameObject.transform.position)-gameObject.transform.position;

			Debug.Log(direction);
			float wearoff = 1 - (direction.magnitude / 10);
			collider.gameObject.GetComponent<Rigidbody2D>().AddForce(direction.normalized * 8000 * wearoff);
			Destroy(gameObject);
		}else if(collider.gameObject.tag == "Obstacle"){
			collider.gameObject.GetComponent<ObstacleBehavior>().detroyObstacle();
		}
	}
}
