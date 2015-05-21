using UnityEngine;
using System.Collections;

public class Goal2 : Goal{
	public Hashtable scores;

	public Goal2():base(){
		scores = new Hashtable ();
	}
	
	public override bool goal(GameObject player,GameObject objectif){
		int playerId = player.GetInstanceID ();
		// On cherche dans le tableau des scores si le joueur existe
		if(!scores.ContainsKey(playerId)){
			bool[] score = {false,false,false}; 
			scores.Add(playerId,score);
		}
		// On recuper son tableau de score
		int objectifId = objectif.GetComponent<Objectif>().idObjectif;
		bool[] objectifs =(bool[]) scores[playerId];
		// On valide l'objectif reçu
		objectifs[objectifId]= true; 

		scores [playerId] = objectifs;
	
		// On test les objectifs, si il en manque un on retourne faux
		foreach (bool o in objectifs) {

			if(!o){return false;}
		}
		// Le joueur a tout ses objectifs, il a gagné
		return true;
	}
}
