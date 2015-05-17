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

	public void setBonusType(GameObject bonus){
		Debug.Log ("Youpi, I've got a AMAZING POWER UP!"+bonus.name);
		transform.FindChild ("Bonus").GetComponent<SpriteRenderer>().sprite = bonus.GetComponent<SpriteRenderer>().sprite;
		this.bonusType = bonus.name;
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
			case "Grappin":grappin();
			break;
			}
			bonusType = "";
			bonusOn = false;
			transform.FindChild ("Bonus").GetComponent<SpriteRenderer>().sprite = null;
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

	public void grappin(){
		Debug.Log("GRAPPIN");
		gameObject.AddComponent<Grappin> ();
	}
}
