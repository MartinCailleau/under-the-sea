using UnityEngine;
using System.Collections;

public class Controle : MonoBehaviour {
	Animator anim;
	Rigidbody2D rigidbody;
	public Vector2 speed = new Vector2(1,1);
	public float maxSpeed = 3;
	public int playerId;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		rigidbody = gameObject.GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {

		float inputX = Input.GetAxis ("Horizontal"+playerId);
		float inputY = Input.GetAxis ("Vertical"+playerId);
		//float inputRotate = Input.GetAxis("Torque");

		anim.SetFloat("speedX",inputX);
		anim.SetFloat("speedY",inputY);

		Vector3 move = new Vector3 (
			speed.x * inputX,
			speed.y * inputY,
			0
		);
		move *= Time.deltaTime;
		//rigidbody.AddTorque (-inputRotate*2);
		rigidbody.AddForce (new Vector2(inputX*speed.x,inputY*speed.y));

		if (rigidbody.velocity.magnitude > maxSpeed) {
			rigidbody.velocity = rigidbody.velocity.normalized * maxSpeed;
		}

	//	transform.Translate(move);

	}

	void FixedUpdate(){
		float lastInputX = Input.GetAxis("Horizontal"+playerId);
		float lastInputY = Input.GetAxis("Vertical"+playerId);

		if (lastInputX != 0 || lastInputY != 0) {
			anim.SetBool ("walking", true);
		 
			if (lastInputX > 0) {
				anim.SetFloat ("lastMoveX", 1f);
			} else if (lastInputX < 0) {
				anim.SetFloat ("lastMoveX", -1f);
			} else {
				anim.SetFloat ("lastMoveX", 0f);
			}

			if (lastInputY > 0) {
				anim.SetFloat ("lastMoveY", 1f);
			} else if (lastInputY < 0) {
				anim.SetFloat ("lastMoveY", -1f);
			} else {
				anim.SetFloat ("lastMoveY", 0f);
			}
		}
		else {
			anim.SetBool ("walking",false);
		}
	}
}
