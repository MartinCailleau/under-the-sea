using UnityEngine;
using System.Collections;
using System;

public class Obstacle {
	public Obstacle(GameObject prefab, Vector2 pos){
		this.prefab = prefab;
		this.pos = pos;
	}
	public GameObject prefab { get; set; }
	public Vector2 pos { get; set; }

}

public class PresetsLoad : MonoBehaviour {
	
	//Prefabs Obstacles
	public GameObject debrisGros, debrisPetit, grenaille, debrisGrosBiais, baudroie, 
	cachalotHorizontal, barreBiaisGauche, epaveBasGauche, 
	barreBiaisDroit, cachalotBiaisGauche, epaveHautDroit, epaveBasDroit, cachalotBiaisDroit,
	barre, barreHorizontale, epaveHautGauche;
	
	GameObject bonus;
	
	public GameObject[] bonusList;

	int i;
	
	//Bandes
	ArrayList bande1= new ArrayList();
	ArrayList bande2= new ArrayList();
	ArrayList bande3= new ArrayList();
	ArrayList bande4= new ArrayList();
	ArrayList bande5= new ArrayList();
	ArrayList bande6= new ArrayList();
	ArrayList bande7= new ArrayList();
	ArrayList bande8= new ArrayList();
	ArrayList bande9= new ArrayList();
	ArrayList bande10= new ArrayList();
	ArrayList bande11= new ArrayList();
	ArrayList bande12= new ArrayList();
	ArrayList bande13= new ArrayList();
	ArrayList bande14= new ArrayList();
	ArrayList bande15= new ArrayList();
	ArrayList bande16= new ArrayList();
	
	ArrayList bandes = new ArrayList();
	
	GameObject detector;
	
	void Start(){
		bonus = new GameObject ();
		bande1.Add(new Obstacle(debrisGros, new Vector2(5, 2)));
		bande1.Add(new Obstacle(epaveBasDroit, new Vector2(20, 4)));
		bande1.Add(new Obstacle(barreHorizontale, new Vector2(38, 2)));
		
		bande2.Add(new Obstacle(debrisGros, new Vector2(13, 2)));
		bande2.Add(new Obstacle(bonus, new Vector2(22, 5)));
		bande2.Add(new Obstacle(barreBiaisGauche, new Vector2(30, 4)));
		
		bande3.Add(new Obstacle(epaveHautGauche, new Vector2(7, 4)));
		bande3.Add(new Obstacle(debrisGros, new Vector2(23, 5)));
		bande3.Add(new Obstacle(epaveBasDroit, new Vector2(36, 8)));
		
		bande4.Add(new Obstacle(cachalotHorizontal, new Vector2(20, 2)));
		bande4.Add(new Obstacle(epaveBasDroit, new Vector2(40, 5)));
		
		bande5.Add(new Obstacle(debrisGros, new Vector2(7, 10)));
		bande5.Add(new Obstacle(debrisGros, new Vector2(22, 2)));
		bande5.Add(new Obstacle(debrisGros, new Vector2(36, 10)));
		
		bande6.Add(new Obstacle(debrisGros, new Vector2(17, 2)));
		bande6.Add(new Obstacle(debrisGros, new Vector2(29, 10)));
		bande6.Add(new Obstacle(debrisGros, new Vector2(45, 2)));
		bande6.Add(new Obstacle(bonus, new Vector2(16, 8)));
		
		bande7.Add(new Obstacle(barreBiaisDroit, new Vector2(9, 4)));
		bande7.Add(new Obstacle(cachalotHorizontal, new Vector2(40, 5)));
		
		bande8.Add(new Obstacle(barreHorizontale, new Vector2(32, 2)));
		bande8.Add(new Obstacle(barreHorizontale, new Vector2(42, 2)));
		
		bande9.Add(new Obstacle(cachalotHorizontal, new Vector2(22, 2)));
		bande9.Add(new Obstacle(baudroie, new Vector2(46, 8)));
		bande9.Add(new Obstacle(debrisGros, new Vector2(36, 3)));
		
		bande10.Add(new Obstacle(debrisGros, new Vector2(17, 2)));
		bande10.Add(new Obstacle(barreBiaisGauche, new Vector2(37, 2)));
		
		bande11.Add(new Obstacle(barreHorizontale, new Vector2(8, 2)));
		bande11.Add(new Obstacle(debrisGros, new Vector2(28, 2)));
		bande11.Add(new Obstacle(bonus, new Vector2(42, 5)));
		
		bande12.Add(new Obstacle(debrisGros, new Vector2(14, 6)));
		bande12.Add(new Obstacle(barreBiaisDroit, new Vector2(26, 6)));
//		bande1.Add(new Obstacle(barreBiaisDroit, new Vector2(46, 4)));
//		//bande1.Add(new Obstacle(barreBiaisDroit, new Vector2(42, 8)));
//		//bande1.Add(new Obstacle(cachalotHorizontal, new Vector2(33, 2)));
//		bande1.Add(new Obstacle(barreBiaisGauche, new Vector2(30, 8)));
//		bande1.Add(new Obstacle(cachalotHorizontal, new Vector2(24, 3)));
//		//bande1.Add(new Obstacle(grenaille, new Vector2(21, 7)));
//		//bande1.Add(new Obstacle(barreBiaisGauche, new Vector2(16, 8)));
//		bande1.Add(new Obstacle(epaveHautGauche, new Vector2(13, 4)));
//		/*bande1.Add(new Obstacle(epaveHautGauche, new Vector2(7, 6)));
//		bande1.Add(new Obstacle(epaveBasDroit, new Vector2(5, 7)));*/
//		bande1.Add(new Obstacle(baudroie, new Vector2(3, 8)));
//		//bande1.Add(new Obstacle(grenaille, new Vector2(1, 1)));
//		
//		bande2.Add(new Obstacle(epaveBasDroit, new Vector2(3, 2)));
//		//bande2.Add(new Obstacle(epaveHautDroit, new Vector2(3, 8)));
//		bande2.Add(new Obstacle(bonus, new Vector2(7, 5)));
//		bande2.Add(new Obstacle(epaveHautGauche, new Vector2(11, 7)));
//		//bande2.Add(new Obstacle(grenaille, new Vector2(11, 2)));
//		bande2.Add(new Obstacle(barreHorizontale, new Vector2(23, 8)));
//		//bande2.Add(new Obstacle(debrisGrosBiais, new Vector2(22, 3)));
//		//bande2.Add(new Obstacle(grenaille, new Vector2(29, 8)));
//		//bande2.Add(new Obstacle(debrisGros, new Vector2(37, 4)));
//		bande2.Add(new Obstacle(barreBiaisDroit, new Vector2(37, 4)));
//		//bande2.Add(new Obstacle(debrisPetit, new Vector2(40, 3)));
//		bande2.Add(new Obstacle(barreBiaisDroit, new Vector2(22, 3)));
//		bande2.Add(new Obstacle(epaveBasGauche, new Vector2(46, 8)));
//		bande2.Add(new Obstacle(barre, new Vector2(49, 3)));
//		
//		bande3.Add(new Obstacle(epaveHautGauche, new Vector2(2, 2)));
//		bande3.Add(new Obstacle(epaveBasDroit, new Vector2(7, 9)));
//		//bande3.Add(new Obstacle(debrisGros, new Vector2(13, 2)));
//		bande3.Add(new Obstacle(barreHorizontale, new Vector2(20, 10)));
//		//bande3.Add(new Obstacle(barre, new Vector2(26, 3)));
//		bande3.Add(new Obstacle(bonus, new Vector2(28, 1)));
//		//bande3.Add(new Obstacle(debrisPetit, new Vector2(32, 2)));
//		bande3.Add(new Obstacle(debrisGros, new Vector2(38, 8)));
//		bande3.Add(new Obstacle(cachalotHorizontal, new Vector2(46, 2)));
//		//bande3.Add(new Obstacle(debrisPetit, new Vector2(48, 8)));
//		bande3.Add(new Obstacle(debrisGrosBiais, new Vector2(21, 5)));
//		
//		bande4.Add(new Obstacle(debrisGros, new Vector2(3, 8)));
//		bande4.Add(new Obstacle(epaveHautDroit, new Vector2(5, 2)));
//		bande4.Add(new Obstacle(epaveHautGauche, new Vector2(16, 2)));
//		bande4.Add(new Obstacle(epaveHautGauche, new Vector2(18, 8)));
//		//bande4.Add(new Obstacle(grenaille, new Vector2(23, 1)));
//		bande4.Add(new Obstacle(debrisPetit, new Vector2(28, 2)));
//		//bande4.Add(new Obstacle(grenaille, new Vector2(29, 6)));
//		bande4.Add(new Obstacle(epaveBasDroit, new Vector2(30, 9)));
//		//bande4.Add(new Obstacle(barre, new Vector2(37, 8)));
//		bande4.Add(new Obstacle(barreBiaisDroit, new Vector2(40, 2)));
//		//bande4.Add(new Obstacle(grenaille, new Vector2(45, 1)));
//		bande4.Add(new Obstacle(baudroie, new Vector2(47, 8)));
//		
//		bande5.Add(new Obstacle(epaveBasGauche, new Vector2(3, 6)));
//		//bande5.Add(new Obstacle(grenaille, new Vector2(11, 10)));
//		//bande5.Add(new Obstacle(grenaille, new Vector2(15, 10)));
//		//bande5.Add(new Obstacle(grenaille, new Vector2(19, 10)));
//		/*bande5.Add(new Obstacle(barreBiaisDroit, new Vector2(8, 3)));
//		bande5.Add(new Obstacle(barreBiaisGauche, new Vector2(12, 8)));
//		bande5.Add(new Obstacle(barreBiaisDroit, new Vector2(20, 7)));*/
//		//bande5.Add(new Obstacle(barreHorizontale, new Vector2(20, 2)));
//		/*bande5.Add(new Obstacle(barreBiaisGauche, new Vector2(30, 5)));
//		bande5.Add(new Obstacle(barreBiaisGauche, new Vector2(30, 8)));*/
//		bande5.Add(new Obstacle(debrisGrosBiais, new Vector2(12, 5)));
//		bande5.Add(new Obstacle(debrisGrosBiais, new Vector2(26, 7)));
//		bande5.Add(new Obstacle(epaveBasDroit, new Vector2(37, 2)));
//		bande5.Add(new Obstacle(cachalotHorizontal, new Vector2(40, 9)));
//		//bande5.Add(new Obstacle(cachalotBiaisDroit, new Vector2(45, 3)));
//		
//		bande6.Add(new Obstacle(epaveHautGauche, new Vector2(3, 2)));
//		//bande6.Add(new Obstacle(epaveHautDroit, new Vector2(9, 2)));
//		bande6.Add(new Obstacle(barreHorizontale, new Vector2(6, 7)));
//		bande6.Add(new Obstacle(barreBiaisDroit, new Vector2(15, 2)));
//		bande6.Add(new Obstacle(debrisPetit, new Vector2(20, 6)));
//		/*bande6.Add(new Obstacle(cachalotHorizontal, new Vector2(22, 7)));*/
//		bande6.Add(new Obstacle(bonus, new Vector2(21, 2)));
//		bande6.Add(new Obstacle(epaveHautGauche, new Vector2(27, 2)));
//		/*bande6.Add(new Obstacle(barreHorizontale, new Vector2(34, 4)));*/
//		bande6.Add(new Obstacle(barreBiaisDroit, new Vector2 (34, 4)));
//		//bande6.Add(new Obstacle(barreHorizontale, new Vector2(42, 4)));
//		bande6.Add(new Obstacle(epaveHautGauche, new Vector2(35, 8)));
//		//bande6.Add(new Obstacle(epaveHautDroit, new Vector2(41, 8)));
//		bande6.Add(new Obstacle(epaveBasDroit, new Vector2(47, 8)));
//		//bande6.Add(new Obstacle(grenaille, new Vector2(49, 1)));
//		
//		bande7.Add(new Obstacle(barre, new Vector2(1, 2)));
//		bande7.Add(new Obstacle(bonus, new Vector2(4, 3)));
//		//bande7.Add(new Obstacle(epaveHautGauche, new Vector2(10, 3)));
//		bande7.Add(new Obstacle(debrisGrosBiais, new Vector2(8, 8)));
//		bande7.Add(new Obstacle(epaveHautDroit, new Vector2(18, 7)));
//		bande7.Add(new Obstacle(barreHorizontale, new Vector2(22, 1)));
//		//bande7.Add(new Obstacle(grenaille, new Vector2(28, 8)));
//		//bande7.Add(new Obstacle(epaveHautGauche, new Vector2(30, 7)));
//		//bande7.Add(new Obstacle(grenaille, new Vector2(31, 2)));
//		bande7.Add(new Obstacle(debrisPetit, new Vector2(34, 8)));
//		bande7.Add(new Obstacle(barreBiaisGauche, new Vector2(42, 4)));
//		bande7.Add(new Obstacle(debrisPetit, new Vector2(48, 2)));
//		//bande7.Add(new Obstacle(grenaille, new Vector2(47, 8)));
//		
//		bande8.Add(new Obstacle(debrisPetit, new Vector2(2, 2)));
//		bande8.Add(new Obstacle(barreHorizontale, new Vector2(6, 8)));
//		//bande8.Add(new Obstacle(debrisPetit, new Vector2(12, 2)));
//		bande8.Add(new Obstacle(barre, new Vector2(19, 7)));
//		bande8.Add(new Obstacle(barre, new Vector2(17, 7)));
//		bande8.Add(new Obstacle(debrisPetit, new Vector2(24, 2)));
//		//bande8.Add(new Obstacle(grenaille, new Vector2(25, 5)));
//		bande8.Add(new Obstacle(debrisPetit, new Vector2(30, 8)));
//		//bande8.Add(new Obstacle(grenaille, new Vector2(33, 4)));
//		//bande8.Add(new Obstacle(grenaille, new Vector2(37, 6)));
//		bande8.Add(new Obstacle(barreHorizontale, new Vector2(40, 1)));
//		bande8.Add(new Obstacle(debrisGrosBiais, new Vector2(44, 7)));
//		
//		//bande9.Add(new Obstacle(barreBiaisDroit, new Vector2(4, 2)));
//		bande9.Add(new Obstacle(debrisPetit, new Vector2(2, 9)));
//		bande9.Add(new Obstacle(debrisGrosBiais, new Vector2(10, 5)));
//		//bande9.Add(new Obstacle(grenaille, new Vector2(11, 1)));
//		bande9.Add(new Obstacle(barreHorizontale, new Vector2(18, 10)));
//		bande9.Add(new Obstacle(baudroie, new Vector2(26, 4)));
//		bande9.Add(new Obstacle(barreBiaisDroit, new Vector2(34, 8)));
//		//bande9.Add(new Obstacle(cachalotHorizontal, new Vector2(32, 2)));
//		//bande9.Add(new Obstacle(barreHorizontale, new Vector2(42, 8)));
//		bande9.Add(new Obstacle(debrisPetit, new Vector2(44, 2)));
//		//bande9.Add(new Obstacle(barre, new Vector2(49, 3)));
		
		/* A REPENSER
		bande9.Add(new Obstacle(barreHorizontale, new Vector2(6, 4)));
		bande9.Add(new Obstacle(grenaille, new Vector2(5, 1)));
		bande9.Add(new Obstacle(debrisGrosBiais, new Vector2(8, 8)));
		bande9.Add(new Obstacle(debrisGrosBiais, new Vector2(16, 3)));
		bande9.Add(new Obstacle(cachalotHorizontal, new Vector2(20, 8)));
		bande9.Add(new Obstacle(barreHorizontale, new Vector2(26, 4)));
		bande9.Add(new Obstacle(grenaille, new Vector2(23, 1)));
		bande9.Add(new Obstacle(cachalotHorizontal, new Vector2(38, 2)));
		bande9.Add(new Obstacle(barreHorizontale, new Vector2(32, 7)));
		bande9.Add(new Obstacle(epaveBasDroit, new Vector2(37, 8)));
		bande9.Add(new Obstacle(epaveBasGauche, new Vector2(47, 8)));
		bande9.Add(new Obstacle(cachalotHorizontal, new Vector2(46, 3)));
		*/
		/*
		bande1.Add(new Obstacle(debrisGros, new Vector2(9, 6)));
		bande1.Add(new Obstacle(debrisPetit, new Vector2(20, 5)));
		bande1.Add(new Obstacle(grenaille, new Vector2(25, 1)));
		bande1.Add(new Obstacle(grenaille, new Vector2(27, 6)));
		bande1.Add(new Obstacle(grenaille, new Vector2(31, 1)));
		bande1.Add(new Obstacle(grenaille, new Vector2(35, 6)));
		bande1.Add(new Obstacle(grenaille, new Vector2(41, 1)));

		bande2.Add(new Obstacle(debrisGrosBiais, new Vector2(4, 4)));
		bande2.Add(new Obstacle(baudroie, new Vector2(9, 4)));
		bande2.Add(new Obstacle(cachalotHorizontal, new Vector2(32, 9)));
		bande2.Add(new Obstacle(barreBiaisGauche, new Vector2(42, 4)));

		bande3.Add(new Obstacle(epaveBasGauche, new Vector2(3, 5)));
		bande3.Add(new Obstacle(bonus, new Vector2(7, 8)));
		bande3.Add(new Obstacle(grenaille, new Vector2(15, 1)));
		bande3.Add(new Obstacle(grenaille, new Vector2(17, 5)));
		bande3.Add(new Obstacle(grenaille, new Vector2(23, 1)));
		bande3.Add(new Obstacle(grenaille, new Vector2(25, 5)));
		bande3.Add(new Obstacle(grenaille, new Vector2(31, 1)));
		bande3.Add(new Obstacle(debrisPetit, new Vector2(38, 9)));
		bande3.Add(new Obstacle(debrisPetit, new Vector2(44, 2)));

		bande4.Add(new Obstacle(debrisPetit, new Vector2(2, 9)));
		bande4.Add(new Obstacle(cachalotHorizontal, new Vector2(14, 7)));
		bande4.Add(new Obstacle(bonus, new Vector2(28, 5)));
		bande4.Add(new Obstacle(grenaille, new Vector2(25, 10)));
		bande4.Add(new Obstacle(grenaille, new Vector2(26, 10)));
		bande4.Add(new Obstacle(barreBiaisDroit, new Vector2(41, 4)));

		bande5.Add(new Obstacle(barreBiaisGauche, new Vector2(7, 7)));
		bande5.Add(new Obstacle(barreBiaisGauche, new Vector2(14, 4)));
		bande5.Add(new Obstacle(barreBiaisDroit, new Vector2(22, 3)));
		bande5.Add(new Obstacle(debrisPetit, new Vector2(28, 10)));
		bande5.Add(new Obstacle(debrisPetit, new Vector2(38, 4)));
		bande5.Add(new Obstacle(grenaille, new Vector2(47, 6)));

		bande6.Add(new Obstacle(cachalotHorizontal, new Vector2(6, 2)));
		bande6.Add(new Obstacle(cachalotHorizontal, new Vector2(6, 8)));
		bande6.Add(new Obstacle(cachalotBiaisGauche, new Vector2(2, 5)));
		bande6.Add(new Obstacle(epaveHautDroit, new Vector2(36, 5)));
		bande6.Add(new Obstacle(debrisPetit, new Vector2(48, 9)));

		bande7.Add(new Obstacle(barreBiaisGauche, new Vector2(10, 7)));
		bande7.Add(new Obstacle(barreBiaisGauche, new Vector2(18, 5)));
		bande7.Add(new Obstacle(cachalotHorizontal, new Vector2(34, 4)));
		bande7.Add(new Obstacle(bonus, new Vector2(45, 1)));
		bande7.Add(new Obstacle(epaveBasDroit, new Vector2(48, 4)));

		bande8.Add(new Obstacle(barreBiaisGauche, new Vector2(10, 4)));
		bande8.Add(new Obstacle(bonus, new Vector2(15, 8)));
		bande8.Add(new Obstacle(cachalotHorizontal, new Vector2(24, 5)));
		bande8.Add(new Obstacle(epaveBasGauche, new Vector2(36, 5)));

		bande9.Add(new Obstacle(cachalotBiaisDroit, new Vector2(9, 5)));
		bande9.Add(new Obstacle(grenaille, new Vector2(19, 4)));
		bande9.Add(new Obstacle(grenaille, new Vector2(21, 8)));
		bande9.Add(new Obstacle(grenaille, new Vector2(27, 4)));
		bande9.Add(new Obstacle(grenaille, new Vector2(29, 8)));
		bande9.Add(new Obstacle(grenaille, new Vector2(35, 4)));
		bande9.Add(new Obstacle(baudroie, new Vector2(45, 5)));

		bande10.Add(new Obstacle(barreBiaisDroit, new Vector2(10, 7)));
		bande10.Add(new Obstacle(barreBiaisGauche, new Vector2(24, 7)));
		bande10.Add(new Obstacle(barreBiaisDroit, new Vector2(36, 3)));
		bande10.Add(new Obstacle(barreBiaisDroit, new Vector2(40, 8)));

		bande11.Add(new Obstacle(grenaille, new Vector2(9, 2)));
		bande11.Add(new Obstacle(grenaille, new Vector2(11, 7)));
		bande11.Add(new Obstacle(grenaille, new Vector2(17, 2)));
		bande11.Add(new Obstacle(grenaille, new Vector2(19, 7)));
		bande11.Add(new Obstacle(grenaille, new Vector2(25, 2)));
		bande11.Add(new Obstacle(debrisPetit, new Vector2(34, 8)));
		bande11.Add(new Obstacle(barre, new Vector2(43, 4)));

		bande12.Add(new Obstacle(grenaille, new Vector2(5, 2)));
		bande12.Add(new Obstacle(grenaille, new Vector2(13, 8)));
		bande12.Add(new Obstacle(barre, new Vector2(17, 5)));
		bande12.Add(new Obstacle(barre, new Vector2(23, 3)));
		bande12.Add(new Obstacle(barreBiaisDroit, new Vector2(35, 8)));
		bande12.Add(new Obstacle(barreBiaisGauche, new Vector2(44, 4)));

		bande13.Add(new Obstacle(epaveHautDroit, new Vector2(6, 7)));
		bande13.Add(new Obstacle(debrisGrosBiais, new Vector2(14, 3)));
		bande13.Add(new Obstacle(bonus, new Vector2(14, 7)));
		bande13.Add(new Obstacle(epaveHautGauche, new Vector2(22, 7)));
		bande13.Add(new Obstacle(barreBiaisDroit, new Vector2(36, 4)));
		bande13.Add(new Obstacle(barre, new Vector2(45, 4)));

		bande14.Add(new Obstacle(epaveHautGauche, new Vector2(4, 3)));
		bande14.Add(new Obstacle(debrisGrosBiais, new Vector2(11, 5)));
		bande14.Add(new Obstacle(epaveHautDroit, new Vector2(18, 3)));
		bande14.Add(new Obstacle(bonus, new Vector2(18, 8)));
		bande14.Add(new Obstacle(debrisGros, new Vector2(31, 4)));
		bande14.Add(new Obstacle(debrisPetit, new Vector2(40, 9)));

		bande15.Add(new Obstacle(epaveBasDroit, new Vector2(8, 3)));
		bande15.Add(new Obstacle(epaveBasDroit, new Vector2(8, 9)));
		bande15.Add(new Obstacle(bonus, new Vector2(10, 5)));
		bande15.Add(new Obstacle(barreBiaisGauche, new Vector2(18, 5)));
		bande15.Add(new Obstacle(grenaille, new Vector2(25, 2)));
		bande15.Add(new Obstacle(barreBiaisDroit, new Vector2(30, 5)));
		bande15.Add(new Obstacle(grenaille, new Vector2(35, 8)));
		bande15.Add(new Obstacle(barreBiaisGauche, new Vector2(42, 5)));

		bande16.Add(new Obstacle(barre, new Vector2(1, 3)));
		bande16.Add(new Obstacle(debrisGros, new Vector2(13, 8)));
		bande16.Add(new Obstacle(cachalotHorizontal, new Vector2(26, 5)));
		bande16.Add(new Obstacle(barreBiaisDroit, new Vector2(39, 4)));
		bande16.Add(new Obstacle(barre, new Vector2(49, 5)));
		*/
		//contient toutes le bandes pour la selection
		bandes.Add(bande1);
		bandes.Add(bande2);
		bandes.Add(bande3);
		bandes.Add(bande4);
		bandes.Add(bande5);
		bandes.Add(bande6);
		bandes.Add(bande7);
		bandes.Add(bande8);
		bandes.Add(bande9);
		bandes.Add(bande10);
		bandes.Add(bande11);
		bandes.Add(bande12);
		/*bandes.Add(bande13);
		bandes.Add(bande14);
		bandes.Add(bande15);
		bandes.Add(bande16);*/
		i = 0;
		selection();
		
	}
	
	void selection(){

//		UnityEngine.Random.seed = (int)(DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond);
//		int rand = UnityEngine.Random.Range (0,12);
//		instanciateBandeA((ArrayList)bandes[rand]);
//
//		Debug.Log ("tuile A : " + rand);
//
//		UnityEngine.Random.seed = (int)(DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond);
//		rand = UnityEngine.Random.Range(0,12);
//		instanciateBandeB((ArrayList)bandes[rand]);
//		
//		Debug.Log ("Tuile B : " + rand);

		instanciateBandeA((ArrayList)bandes[i]);
		++i;
		instanciateBandeB((ArrayList)bandes[i]);
		if (i == 11) { i = 0;}

		//Detecteur
		detector = new GameObject();
		detector.transform.position = new Vector2(0, 10);
		Rigidbody2D rg = detector.AddComponent<Rigidbody2D>();
		rg.mass = 1000;
		rg.drag = 5;
	}
	
	void instanciateBandeA(ArrayList bande){
		foreach(Obstacle obs in bande){
			
			Vector2 posCorrected = new Vector2(obs.pos.x/2.5f, (16-obs.pos.y)+10);
			if(obs.prefab == bonus){

				UnityEngine.Random.seed = (int)(DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond);
				int nbRand = UnityEngine.Random.Range(0,bonusList.Length);
				Debug.Log(nbRand);
				obs.prefab = bonusList[nbRand];
			}
			GameObject go = GameObject.Instantiate(obs.prefab, (Vector3)posCorrected, obs.prefab.transform.rotation) as GameObject;
			go.name = obs.prefab.name;
			
		}
	}
	
	void instanciateBandeB(ArrayList bande){
		foreach(Obstacle obs in bande){
			Vector2 posCorrected = new Vector2((obs.pos.x-50)/2.5f, (16-obs.pos.y)+10); //pour y on inverse l'axe et on recule un peu pour leurs donner un retrait
			if(obs.prefab == bonus){
				UnityEngine.Random.seed = (int)(DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond);
				int nbRand = UnityEngine.Random.Range(0,bonusList.Length);
				Debug.Log(nbRand);
				obs.prefab = bonusList[nbRand];
			}
			GameObject go = GameObject.Instantiate(obs.prefab, (Vector3)posCorrected, obs.prefab.transform.rotation) as GameObject;
			go.name = obs.prefab.name;
			
		}
	}
	
	void Update(){
		if(detector.transform.position.y <=0){
			GameObject.Destroy(detector);
			selection();
		}
	}
}
