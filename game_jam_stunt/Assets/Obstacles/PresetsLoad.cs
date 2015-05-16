using UnityEngine;
using System.Collections;

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
	public GameObject debrisGros, debrisPetit, grenaille, debrisPetitBiais, baudroie, 
		cachalotHorizontal, barreBiaisGauche, epaveBasGauche, bonus, 
	barreBiaisDroit, cachalotBiaisGauche, epaveHautDroit, epaveBasDroit, cachalotBiaisDroit,
	barre, epaveHautGauche;

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
		bande1.Add(new Obstacle(debrisGros, new Vector2(9, 9)));
		bande1.Add(new Obstacle(debrisPetit, new Vector2(20, 8)));
		bande1.Add(new Obstacle(grenaille, new Vector2(25, 1)));
		bande1.Add(new Obstacle(grenaille, new Vector2(27, 9)));
		bande1.Add(new Obstacle(grenaille, new Vector2(31, 1)));
		bande1.Add(new Obstacle(grenaille, new Vector2(35, 9)));
		bande1.Add(new Obstacle(grenaille, new Vector2(41, 1)));

		bande2.Add(new Obstacle(debrisPetitBiais, new Vector2(4, 6)));
		bande2.Add(new Obstacle(baudroie, new Vector2(9, 6)));
		bande2.Add(new Obstacle(cachalotHorizontal, new Vector2(32, 14)));
		bande2.Add(new Obstacle(barreBiaisGauche, new Vector2(42, 5)));

		bande3.Add(new Obstacle(epaveBasGauche, new Vector2(3, 7)));
		bande3.Add(new Obstacle(bonus, new Vector2(7, 12)));
		bande3.Add(new Obstacle(grenaille, new Vector2(15, 1)));
		bande3.Add(new Obstacle(grenaille, new Vector2(17, 7)));
		bande3.Add(new Obstacle(grenaille, new Vector2(23, 1)));
		bande3.Add(new Obstacle(grenaille, new Vector2(25, 7)));
		bande3.Add(new Obstacle(grenaille, new Vector2(31, 1)));
		bande3.Add(new Obstacle(debrisPetit, new Vector2(38, 14)));
		bande3.Add(new Obstacle(debrisPetit, new Vector2(44, 2)));

		bande4.Add(new Obstacle(debrisPetit, new Vector2(2, 14)));
		bande4.Add(new Obstacle(cachalotHorizontal, new Vector2(14, 10)));
		bande4.Add(new Obstacle(bonus, new Vector2(28, 8)));
		bande4.Add(new Obstacle(grenaille, new Vector2(25, 15)));
		bande4.Add(new Obstacle(grenaille, new Vector2(26, 15)));
		bande4.Add(new Obstacle(barreBiaisDroit, new Vector2(41, 5)));

		bande5.Add(new Obstacle(barreBiaisGauche, new Vector2(7, 11)));
		bande5.Add(new Obstacle(barreBiaisGauche, new Vector2(14, 6)));
		bande5.Add(new Obstacle(barreBiaisDroit, new Vector2(22, 4)));
		bande5.Add(new Obstacle(debrisPetit, new Vector2(28, 14)));
		bande5.Add(new Obstacle(debrisPetit, new Vector2(38, 6)));
		bande5.Add(new Obstacle(grenaille, new Vector2(47, 9)));

		bande6.Add(new Obstacle(cachalotHorizontal, new Vector2(6, 2)));
		bande6.Add(new Obstacle(cachalotHorizontal, new Vector2(6, 12)));
		bande6.Add(new Obstacle(cachalotBiaisGauche, new Vector2(2, 7)));
		bande6.Add(new Obstacle(epaveHautDroit, new Vector2(36, 8)));
		bande6.Add(new Obstacle(debrisPetit, new Vector2(48, 14)));

		bande7.Add(new Obstacle(barreBiaisGauche, new Vector2(10, 10)));
		bande7.Add(new Obstacle(barreBiaisGauche, new Vector2(18, 8)));
		bande7.Add(new Obstacle(cachalotHorizontal, new Vector2(34, 6)));
		bande7.Add(new Obstacle(bonus, new Vector2(45, 1)));
		bande7.Add(new Obstacle(epaveBasDroit, new Vector2(48, 6)));

		bande8.Add(new Obstacle(barreBiaisGauche, new Vector2(10, 6)));
		bande8.Add(new Obstacle(bonus, new Vector2(15, 13)));
		bande8.Add(new Obstacle(cachalotHorizontal, new Vector2(24, 8)));
		bande8.Add(new Obstacle(epaveBasGauche, new Vector2(36, 8)));

		bande9.Add(new Obstacle(cachalotBiaisDroit, new Vector2(9, 7)));
		bande9.Add(new Obstacle(grenaille, new Vector2(19, 5)));
		bande9.Add(new Obstacle(grenaille, new Vector2(21, 13)));
		bande9.Add(new Obstacle(grenaille, new Vector2(27, 5)));
		bande9.Add(new Obstacle(grenaille, new Vector2(29, 13)));
		bande9.Add(new Obstacle(grenaille, new Vector2(35, 5)));
		bande9.Add(new Obstacle(baudroie, new Vector2(45, 8)));

		bande10.Add(new Obstacle(barreBiaisDroit, new Vector2(10, 10)));
		bande10.Add(new Obstacle(barreBiaisGauche, new Vector2(24, 10)));
		bande10.Add(new Obstacle(barreBiaisDroit, new Vector2(36, 4)));
		bande10.Add(new Obstacle(barreBiaisDroit, new Vector2(40, 12)));

		bande11.Add(new Obstacle(grenaille, new Vector2(9, 3)));
		bande11.Add(new Obstacle(grenaille, new Vector2(11, 11)));
		bande11.Add(new Obstacle(grenaille, new Vector2(17, 3)));
		bande11.Add(new Obstacle(grenaille, new Vector2(19, 11)));
		bande11.Add(new Obstacle(grenaille, new Vector2(25, 3)));
		bande11.Add(new Obstacle(debrisPetit, new Vector2(34, 12)));
		bande11.Add(new Obstacle(barre, new Vector2(43, 6)));

		bande12.Add(new Obstacle(grenaille, new Vector2(5, 3)));
		bande12.Add(new Obstacle(grenaille, new Vector2(13, 13)));
		bande12.Add(new Obstacle(barre, new Vector2(17, 8)));
		bande12.Add(new Obstacle(barre, new Vector2(23, 4)));
		bande12.Add(new Obstacle(barreBiaisDroit, new Vector2(35, 12)));
		bande12.Add(new Obstacle(barreBiaisGauche, new Vector2(44, 6)));

		bande13.Add(new Obstacle(epaveHautDroit, new Vector2(6, 10)));
		bande13.Add(new Obstacle(debrisPetitBiais, new Vector2(14, 4)));
		bande13.Add(new Obstacle(bonus, new Vector2(14, 10)));
		bande13.Add(new Obstacle(epaveHautGauche, new Vector2(22, 10)));
		bande13.Add(new Obstacle(barreBiaisDroit, new Vector2(36, 6)));
		bande13.Add(new Obstacle(barre, new Vector2(45, 6)));

		bande14.Add(new Obstacle(epaveHautGauche, new Vector2(4, 4)));
		bande14.Add(new Obstacle(debrisPetitBiais, new Vector2(11, 8)));
		bande14.Add(new Obstacle(epaveHautDroit, new Vector2(18, 4)));
		bande14.Add(new Obstacle(bonus, new Vector2(18, 12)));
		bande14.Add(new Obstacle(debrisGros, new Vector2(31, 5)));
		bande14.Add(new Obstacle(debrisPetit, new Vector2(40, 14)));

		bande15.Add(new Obstacle(epaveBasDroit, new Vector2(8, 4)));
		bande15.Add(new Obstacle(epaveBasDroit, new Vector2(8, 14)));
		bande15.Add(new Obstacle(bonus, new Vector2(10, 8)));
		bande15.Add(new Obstacle(barreBiaisGauche, new Vector2(18, 8)));
		bande15.Add(new Obstacle(grenaille, new Vector2(25, 3)));
		bande15.Add(new Obstacle(barreBiaisDroit, new Vector2(30, 8)));
		bande15.Add(new Obstacle(grenaille, new Vector2(35, 13)));
		bande15.Add(new Obstacle(barreBiaisGauche, new Vector2(42, 8)));

		bande16.Add(new Obstacle(barre, new Vector2(1, 4)));
		bande16.Add(new Obstacle(debrisGros, new Vector2(13, 13)));
		bande16.Add(new Obstacle(cachalotHorizontal, new Vector2(26, 8)));
		bande16.Add(new Obstacle(barreBiaisDroit, new Vector2(39, 6)));
		bande16.Add(new Obstacle(barre, new Vector2(49, 8)));

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
		bandes.Add(bande13);
		bandes.Add(bande14);
		bandes.Add(bande15);
		bandes.Add(bande16);

		selection();

	}

	void selection(){
		int rand = Random.Range (0,15);
		instanciateBandeA((ArrayList)bandes[rand]);

		rand = Random.Range(0,15);
		instanciateBandeB((ArrayList)bandes[rand]);

		detector = new GameObject();
		detector.transform.position = new Vector2(0, 15);
		Rigidbody2D rg = detector.AddComponent<Rigidbody2D>();
		rg.mass = 1000;
		rg.drag = 5;
	}

	void instanciateBandeA(ArrayList bande){
		foreach(Obstacle obs in bande){
			Vector2 posCorrected = new Vector2(obs.pos.x/2.1f, (16-obs.pos.y)+10);
			GameObject.Instantiate(obs.prefab, (Vector3)posCorrected, obs.prefab.transform.rotation);
		}
	}

	void instanciateBandeB(ArrayList bande){
		foreach(Obstacle obs in bande){
			Vector2 posCorrected = new Vector2((obs.pos.x-50)/2.5f, (16-obs.pos.y)+10); //pour y on inverse l'axe et on recule un peu pour leurs donner un retrait
			GameObject.Instantiate(obs.prefab, (Vector3)posCorrected, obs.prefab.transform.rotation);
		}
	}

	void Update(){
		if(detector.transform.position.y <=0){
			GameObject.Destroy(detector);
			selection();
		}
	}
}
