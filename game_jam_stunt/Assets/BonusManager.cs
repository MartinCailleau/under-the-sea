using UnityEngine;
using System.Collections;

public class BonusManager : MonoBehaviour {
	public string bonusType;
	public bool bonusOn;
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
			}
			bonusType = "";
			bonusOn = false;
		}
	}

	public void lightFreeze(){
		Debug.Log ("FREEZE!");
		gameObject.AddComponent<LightFreeze>();

	}

	public void iem(){
		Debug.Log ("IEM!");
		gameObject.AddComponent<IEM> ();
		gameObject.GetComponent<IEM> ().initIEM(2,gameObject);
	}
}
