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
	public float attackstartspeed = 0.5f;
	public float attackSpeed = 1.2f;
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
			Anim.runtimeAnimatorController = Move;
			float distanceToPlayer = 0.0f;
			Vector3 playerPosition = target.transform.position;
			moveDirection = new Vector2 (playerPosition.x - transform.position.x, playerPosition.y - transform.position.y);
			distanceToPlayer = moveDirection.magnitude;
			gameObject.GetComponent<Rigidbody2D> ().velocity = moveDirection;

			if (distanceToPlayer < chaseTriggerDistance) {
				attack ();
			}
		} else {
			gameObject.GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, 0);
			timer += Time.deltaTime;
			if (timer >= attackstartspeed) {
				SwordHitBox.GetComponent<BoxCollider2D> ().enabled = true;
			} else if (timer >= attackSpeed) {
				SwordHitBox.GetComponent<BoxCollider2D> ().enabled = false;
				attacking = false;
				timer = 0;
			}										
		}
	}

	void attack()
	{
		attacking = true;
		Anim.runtimeAnimatorController = Attack;
	}
}
