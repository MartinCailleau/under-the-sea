using UnityEngine;
using System.Collections;

public class EasterEgg : MonoBehaviour {
	public GameObject prefab;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if(Input.GetKeyDown(KeyCode.F) && Input.GetKeyDown(KeyCode.U) && Input.GetKeyDown(KeyCode.C) && Input.GetKeyDown(KeyCode.K)){
			Instantiate(prefab,prefab.transform.position,prefab.transform.rotation);
		}
	}
}
