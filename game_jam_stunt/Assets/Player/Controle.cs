using UnityEngine;
using System.Collections;

public class Controle : MonoBehaviour {
	Animator anim;
	Animator animNumber;
	Rigidbody2D rigidbody;
	public Vector2 speed = new Vector2(1,1);
	public float maxSpeed = 3;
	public int playerId;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		animNumber = transform.FindChild ("Number").GetComponent<Animator>();
		rigidbody = gameObject.GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {

		float inputX = Input.GetAxis ("Horizontal"+playerId);
		float inputY = Input.GetAxis ("Vertical"+playerId);
		Debug.Log (inputX);
		//float inputRotate = Input.GetAxis("Torque");

		anim.SetFloat("speedX",inputX);
		animNumber.SetFloat("speedX",inputX);
		//rigidbody.AddTorque (-inputRotate*2);
		rigidbody.AddForce (new Vector2(inputX*speed.x,inputY*speed.y));

		if (rigidbody.velocity.magnitude > maxSpeed) {
			rigidbody.velocity = rigidbody.velocity.normalized * maxSpeed;
		}

		if (Input.GetButtonDown("A"+playerId)) {
			gameObject.GetComponent<BonusManager>().useBonus();
		}

	}

}
