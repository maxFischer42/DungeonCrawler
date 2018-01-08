using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangerToLight : MonoBehaviour {

	public float hp = 6.0f;
	
	// Update is called once per frame
	void Update () {
		if (hp <= 0) {
			Destroy (gameObject);
		}
	}


	void OnTriggerEnter2D(Collider2D Coll)
	{
		if (Coll.gameObject.tag == "Light") {
			hp--;
		}
	}
}
