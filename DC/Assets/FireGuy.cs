using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireGuy : MonoBehaviour {

	public SpriteRenderer Sprt;
	public Sprite Frozen;
	public bool state = false;
	public CircleCollider2D Circ;
	public BoxCollider2D Icecube;
	public Barrel Bar;
	public EnemyChase en;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (state) {
			Sprt.sprite = Frozen;
			Circ.enabled = false;
			Icecube.enabled = true;
			Bar.enabled = true;
			en.enabled = false;
			gameObject.GetComponent<Animator> ().enabled = false;
		}

	}

	void OnTriggerEnter2D(Collider2D Coll)
	{
		if (Coll.gameObject.tag == "Ice") {
			state = true;
			Debug.Log ("Iced");
		}
	}
}
