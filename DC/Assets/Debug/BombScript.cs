using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombScript : MonoBehaviour {

	public float Ammo = 1.0f;
	public GameObject Bomb;
	bool coolDown;
	float timer = 0;

	void Update () {
		timer += Time.deltaTime;
		if (coolDown && timer > 2) {
			timer = 0;
			coolDown = false;
		}


		if (Input.GetAxis ("Fire1") > 0 && Ammo > 0.0f && coolDown != true) {
			Instantiate (Bomb, transform.position, Quaternion.identity);
			Ammo -= 0.1f;
				coolDown = true;
		}
	}


}
