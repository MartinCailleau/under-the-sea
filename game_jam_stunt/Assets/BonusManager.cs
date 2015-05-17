using UnityEngine;
using System.Collections;

public class BonusManager : MonoBehaviour {
	public string bonusType;
	public bool bonusOn;
	public GameObject bumper;
	// Use this for initialization
	void Start () {
		bonusOn = false;
		bonusType = "";
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void setBonusType(string bonusType){
		Debug.Log ("Youpi, I've got a AMAZING POWER UP!"+bonusType);
		this.bonusType = bonusType;
		bonusOn = true;
	}

	public void useBonus(){
		if(bonusOn){
			switch (bonusType) {
			case "LightFreeze":lightFreeze();
			break;
			case "IEM":iem();
			break;
			case "Bumper":Bumper();
			break;
			}
			bonusType = "";
			bonusOn = false;
		}
	}

	public void lightFreeze(){
		Debug.Log ("FREEZE!");
		gameObject.AddComponent<LightFreeze>();

	}

	public void Bumper (){
		Debug.Log ("BUMP!");

		GameObject go = Instantiate (bumper, gameObject.transform.position, Quaternion.identity) as GameObject;
		go.transform.parent = gameObject.transform;
	}

	public void iem(){
		Debug.Log ("IEM!");
		gameObject.AddComponent<IEM> ();
		gameObject.GetComponent<IEM> ().initIEM(2,gameObject);
	}
}
