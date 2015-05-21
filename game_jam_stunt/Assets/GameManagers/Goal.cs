using UnityEngine;
using System.Collections;

public class Goal :MonoBehaviour{
	public Goal (){
	}
	public virtual bool goal(GameObject player,GameObject objectif){
		return false;
	}
}
