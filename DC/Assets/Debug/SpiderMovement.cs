using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderMovement : MonoBehaviour {


	public Rigidbody2D Rig;
	public float speed = 3.0f;
	float timer = 0;

	
	// Update is called once per frame
	void Update ()
	{
		timer += Time.deltaTime;
		float rand = Random.Range (-1, 1);
		float xrand = Random.Range (-1, 1);

			Rig.velocity = new Vector2 (rand * xrand * speed, rand * xrand * speed);

	}
}
