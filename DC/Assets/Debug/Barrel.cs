using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrel : MonoBehaviour {

	int barrelHP = 30;
	public Sprite damage1;
	public Sprite damage2;
	public SpriteRenderer sprt;



	void Update () {

		if (barrelHP < 20) {
			sprt.sprite = damage1;
		}
		else if(barrelHP < 10) {
			sprt.sprite = damage2;
		}


		if (barrelHP <= 0) {
			Destroy (gameObject);
		}
	}

	void OnTriggerStay2D(Collider2D Coll)
	{
		if (Coll.gameObject.tag == "Sword") {
			barrelHP--;
		}
	}
}
