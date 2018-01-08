using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordSlash : MonoBehaviour {

	private bool slashing = false;
	public PlayerAnimator Animator;
	public Collider2D Coll;
	float timer = 0;


	
	// Update is called once per frame
	void Update () {

		timer += Time.deltaTime;

		if(Input.GetAxis("Fire1") > 0 && slashing == false)
		{
			slashing = true;
			Animator.swinging = true;
			Coll.enabled = true;
			timer = 0;
		}

		if (timer > 0.8f) {
			slashing = false;
			Animator.swinging = false;
			Coll.enabled = false;

		}


	}


}
