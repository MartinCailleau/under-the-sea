using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour {

	public void play(){
		Application.LoadLevel("Level1");
	}

	public void exit(){
		Application.Quit();
	}
}
