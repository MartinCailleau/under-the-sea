using UnityEngine;
using System.Collections;

public class Tarbathor : MonoBehaviour {

	// Use this for initialization
	void Start () {
		int i = 100;
		foreach(Rigidbody r in GetComponentsInChildren<Rigidbody> ()){
			r.AddForce(new Vector3(0,1000,0));

			r.AddTorque(new Vector3(0,50+(Random.value*100),0));

		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
