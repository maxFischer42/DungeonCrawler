using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BearTrap : MonoBehaviour {

	public Sprite Closed;
	private SpriteRenderer Sprt;
	bool closedTrue;
	float timer = 0;
	private GameObject Player;

	// Use this for initialization
	void Start () {
		Sprt = gameObject.GetComponent<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (closedTrue) {
			timer += Time.deltaTime;
			if (timer > 0.2) {
				Player.GetComponent<HP> ().Hp -= 0.04f;
			}

		}
	}

	void OnTriggerEnter2D(Collider2D Coll)
	{
		if (Coll.gameObject.tag == "Player")
		{
			Player = Coll.gameObject;
			Player.GetComponent<PlayerAnimator> ().enabled = false;

			Sprt.sprite = Closed;
			Player.GetComponent<Animator> ().enabled = false;
			Player.GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, 0);
			Player.GetComponent<Rigidbody2D> ().bodyType = RigidbodyType2D.Static;
			Vector2 pos = transform.position;
			pos = new Vector2 (pos.x, pos.y + 0.5f);
			Player.transform.SetPositionAndRotation (pos, Quaternion.identity);
			Sprt.sortingOrder = 10;
			closedTrue = true;
		}


	}
}
