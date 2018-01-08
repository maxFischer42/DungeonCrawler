using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeakToDark : MonoBehaviour {

	public float hp = 6.0f;

	// Update is called once per frame
	void Update () {
		if (hp <= 0) {
			Destroy (gameObject);
		}
	}


	void OnTriggerEnter2D(Collider2D Coll)
	{
		if (Coll.gameObject.tag == "Dark") {
			hp--;
			gameObject.GetComponent<Rigidbody2D> ().velocity =
				new Vector2 (gameObject.GetComponent<Rigidbody2D> ().velocity.x * -2,
					gameObject.GetComponent<Rigidbody2D> ().velocity.y * -2);
		}
	}
}
