using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight : MonoBehaviour {

	public GameObject target;
	public float chaseSpeed = 2.0f;
	private bool home = true;
	private Vector3 homePos;

	private Vector2 moveDirection;

	public float maxMoveDistance = 10.0f;
	public float chaseTriggerDistance = 1.0f;
	public Sprite Defeat;
	public Animator Anim;
	public RuntimeAnimatorController Move;
	public RuntimeAnimatorController Attack;
	public SpriteRenderer Sprt;
	float attackstartspeed = 0.5f;
	float attackSpeed = 1.2f;
	float timer = 0;
	public GameObject SwordHitBox;

	bool attacking = false;

	void Start () {
		homePos = transform.position;

	}

	// Update is called once per frame
	void Update () {
		if (attacking != true) {
			target = GameObject.FindGameObjectWithTag ("Player");
			float distanceToPlayer = 0.0f;
			Vector3 playerPosition = target.transform.position;
			moveDirection = new Vector2 (playerPosition.x - transform.position.x, playerPosition.y - transform.position.y);
			distanceToPlayer = moveDirection.magnitude;


			if (distanceToPlayer < chaseTriggerDistance) {
				attack ();
			}
		} else {
			timer += Time.deltaTime;
			if (timer >= attackstartspeed) {
				SwordHitBox.GetComponent<BoxCollider2D> ().enabled = true;
			} else if (timer >= attackSpeed) {
				SwordHitBox.GetComponent<BoxCollider2D> ().enabled = true;
				attacking = false;
				timer = 0;
			}

			var vel = gameObject.GetComponent<Rigidbody2D> ().velocity;
			if (vel.x == 0 && vel.y == 0) {
				Anim.runtimeAnimatorController = Attack;
			} else {
				Anim.runtimeAnimatorController = Move;
			}



		}
	}

	void attack()
	{
		attacking = true;
	}
}
