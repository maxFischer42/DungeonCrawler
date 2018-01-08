using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D Coll)
	{
		if (Coll.gameObject.tag == "Player" && Coll.gameObject.GetComponent<HP> ().Hp != Coll.gameObject.GetComponent<HP> ().maxHp) {
			Coll.gameObject.GetComponent<HP> ().Hp += 0.5f;
			Destroy (gameObject);

		}
	}
}
