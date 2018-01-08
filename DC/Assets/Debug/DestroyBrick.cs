using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBrick : MonoBehaviour {

	public bool touchbomb;
	void OnTriggerEnter2D(Collider2D Coll)
	{
		Debug.Log ("CBomb");
		touchbomb = true;
		if (Coll.gameObject.tag == "Bomb") {
			Destroy(gameObject);
		}
	}

}
