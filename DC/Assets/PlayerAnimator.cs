using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour {

	public RuntimeAnimatorController Idle;
	public RuntimeAnimatorController Run;
	public RuntimeAnimatorController RunU;
	public RuntimeAnimatorController Sword;
	public RuntimeAnimatorController Fire;
	public RuntimeAnimatorController Ice;
	public RuntimeAnimatorController Elec;
	public RuntimeAnimatorController Light;
	public RuntimeAnimatorController Dark;

	public Animator Anim;

	public bool charging = false;
	public int magic;
	public bool swinging = false;

	public Rigidbody2D Rig;

	public float speed;








	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{

		if (charging) {
			if (magic == 0) {
				Anim.runtimeAnimatorController = Fire;
			} else if (magic == 1) {
				Anim.runtimeAnimatorController = Ice;
			} else if (magic == 2) {
				Anim.runtimeAnimatorController = Elec;
			} else if (magic == 3) {
				Anim.runtimeAnimatorController = Light;
			} else if (magic == 4) {
				Anim.runtimeAnimatorController = Dark;
			}
		} else if (swinging) {
			Anim.runtimeAnimatorController = Sword;
		} else {
			var x = Input.GetAxis ("Horizontal");
			var y = Input.GetAxis ("Vertical");

			if (y > 0 ) {
				Anim.runtimeAnimatorController = RunU;
			} else if (y < 0|| x > 0 || x < 0) {
				Anim.runtimeAnimatorController = Run;
			}

			if (y == 0 && x == 0) {
				Anim.runtimeAnimatorController = Idle;
			}

			Vector2 Vel = Rig.velocity;
			Vel = new Vector2 (x * speed, y * speed);
			Rig.velocity = Vel;



		}


	}
}
