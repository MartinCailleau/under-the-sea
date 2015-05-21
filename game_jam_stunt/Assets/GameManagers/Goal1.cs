using UnityEngine;
using System.Collections;

public class Goal1 : Goal{
	public Hashtable scores;
	
	public Goal1():base(){
		scores = new Hashtable ();
	}

	public override bool goal(GameObject player,GameObject objectif){
		return true;
	}
}