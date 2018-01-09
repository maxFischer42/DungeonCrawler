using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pond : MonoBehaviour {

	private BoxCollider2D Box;
	private SpriteRenderer Sprt;
	private Animator Anim;
	public Sprite Ice;

	private void Start()
	{
		Box = transform.GetChild (0).GetComponent<BoxCollider2D> ();
		Sprt = transform.GetChild (0).GetComponent<SpriteRenderer> ();
		Anim = transform.GetChild (0).GetComponent<Animator> ();
	}

	void OnTriggerEnter2D(Collider2D Coll)
	{
		if (Coll.gameObject.tag == "Ice")
		{	Box.enabled = false;
			Anim.enabled = false;
			Sprt.sprite = Ice;
			}
	}


}
