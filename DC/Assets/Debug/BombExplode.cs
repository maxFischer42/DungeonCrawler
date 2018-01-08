using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombExplode : MonoBehaviour {

	public BoxCollider2D Coll;
	public float timer;
	public RuntimeAnimatorController Expl;
	public Animator Anim;
	public GameObject Bomb;

	// Use this for initialization
	void Awake () {
		
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if (timer > 2) {
			gameObject.GetComponent<SpriteRenderer> ().enabled = true;
			Anim.runtimeAnimatorController = Expl;
			Coll.enabled = true;
		}
		if (timer > 3) {
			Destroy (Bomb);
		}
	}

	void OnCollisionEnter2D(Collision2D Coll)
	{
		Debug.Log ("Coll");
		if (Coll.gameObject.tag == "BrickWall") {
		Destroy(Coll.gameObject);
		}
	}

}
