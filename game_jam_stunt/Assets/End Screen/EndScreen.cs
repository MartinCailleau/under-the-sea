using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EndScreen : MonoBehaviour {

	public string winner;
	public Text text;

	// Use this for initialization
	public void activeScreen(){
		text.GetComponent<Text>().text = "Player " + winner + " win !";
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("A1") || Input.GetButtonDown("A2") || Input.GetButtonDown("A3") || Input.GetButtonDown("A4")){
			if(Application.loadedLevelName == "Level1"){
				Application.LoadLevel("Level2");
			}else if (Application.loadedLevelName == "Level2"){
				Application.LoadLevel("Level1");
			}
		}
	}
}
