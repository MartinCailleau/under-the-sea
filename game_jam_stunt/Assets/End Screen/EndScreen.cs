﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EndScreen : MonoBehaviour {

	public string winner;

	// Use this for initialization
	public void activeScreen(){

	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("A1") || Input.GetButtonDown("A2") || Input.GetButtonDown("A3") || Input.GetButtonDown("A4")){
			Application.LoadLevel("Proto");
		}
	}
}
