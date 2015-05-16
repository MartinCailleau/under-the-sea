using UnityEngine;
using System.Collections;

public class Controle : MonoBehaviour {
	Animator anim;
	public Vector2 speed = new Vector2(1,1);
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {

		float inputX = Input.GetAxis ("Horizontal");
		float inputY = Input.GetAxis ("Vertical");
		anim.SetFloat("speedX",inputX);
		anim.SetFloat("speedY",inputY);

		Vector3 move = new Vector3 (
			speed.x * inputX,
			speed.y * inputY,
			0
		);
		move *= Time.deltaTime;

		transform.Translate (move);

	}

	void FixedUpdate(){
		float lastInputX = Input.GetAxis("Horizontal");
		float lastInputY = Input.GetAxis("Vertical");

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
