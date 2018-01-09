using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyActive : MonoBehaviour {

	public EnemyChase En1;
	public enemyShoot En2;
	public SpiderMovement En3;
	public OrbScript En4;

	void OnTriggerEnter2D(Collider2D Coll)
	{
		if (Coll.gameObject.tag == "Player") {
			En1.enabled = true;
			En2.enabled = true;
			En3.enabled = true;
			En4.enabled = true;
		}
	}


	void OnTriggerExit2D(Collider2D Coll)
	{
		if (Coll.gameObject.tag == "Player") {
			En1.enabled = false;
			En2.enabled = false;
			En3.enabled = false;
			En4.enabled = false;
		}
	}
}
