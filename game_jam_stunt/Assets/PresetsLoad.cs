using UnityEngine;
using System;
using System.Collections;

public class Obstacle {
	public Obstacle(string name, Vector2 pos){
		this.name = name;
		this.pos = pos;
	}
	public string name { get; set; }
	public Vector2 pos { get; set; }
}

public class PresetsLoad : MonoBehaviour {

	void Start(){

		ArrayList bande1 = new ArrayList();
		bande1.Add(new Obstacle("debrisGros", new Vector2(9, 9)));
		bande1.Add(new Obstacle("debrisPetit", new Vector2(20, 8)));
		bande1.Add(new Obstacle("grenaille", new Vector2(25, 1)));
		bande1.Add(new Obstacle("grenaille", new Vector2(27, 9)));
		bande1.Add(new Obstacle("grenaille", new Vector2(31, 1)));
		bande1.Add(new Obstacle("grenaille", new Vector2(35, 9)));
		bande1.Add(new Obstacle("grenaille", new Vector2(41, 1)));

		foreach(Obstacle tm in bande1){
			Debug.Log(tm.name + "   " + tm.pos);
		}
		

		/*bande1 = new Hashtable();
		bande1.Add("debrisGros", new Vector2(9, 9));
		bande1.Add("debrisPetit", new Vector2(20, 8));
		bande1.Add("grenaille1", new Vector2(25, 1));
		bande1.Add("grenaille2", new Vector2(27, 9));
		bande1.Add("grenaille3", new Vector2(31, 1));
		bande1.Add("grenaille4", new Vector2(35, 9));
		bande1.Add("grenaille5", new Vector2(41, 1));

		foreach(DictionaryEntry de in bande1){
			Debug.Log("Clé : " + de.Key + " | Valeur : " + de.Value);
		}*/

	}

}
