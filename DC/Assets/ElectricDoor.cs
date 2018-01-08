using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectricDoor : MonoBehaviour {

	public RuntimeAnimatorController DoorOpen;
	public Animator Anim;

	bool opened = false;
	float timer = 0;
	
	// Update is called once per frame
	void Update () {
		if (opened) {
			timer += Time.deltaTime;
			if (timer > 0.4) {
				Destroy (gameObject);
			}




		}
	}

	void OnTriggerEnter2D(Collider2D Coll)
	{
		if (Coll.gameObject.tag == "Elec") {
			opened = true;
			Anim.runtimeAnimatorController = DoorOpen;
		}
	}


}
