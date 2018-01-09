using UnityEngine;
using System.Collections;

public class enemyShoot : MonoBehaviour {

	public GameObject Player;
	public GameObject prefab;
	public float bulletSpeed = 10f;
	public float bulletLifetime = 1.0f;
	public float shootDelay = 1.0f;
	private float timer = 0;



	void Start () {
		timer = shootDelay;
		Player = GameObject.FindGameObjectWithTag ("Player");
	}

	// Update is called once per frame
	void Update () {








		timer += Time.deltaTime;
		if (timer > shootDelay) {
			//get the mouse position
			var mousePosition = Player.transform.position;
			//create the shoot direction, which is calculated by mousePosition - playerPosition
			Vector2 shootDirection = new Vector2 (mousePosition.x - transform.position.x, mousePosition.y - transform.position.y);
			//create the bullet object

			//reduce the length of the direction to 1, so it is always the same regardless of how far away
			//the mouse is from the player. 
			shootDirection.Normalize();

			Vector3 spawnPosition = transform.position;
			spawnPosition.x += shootDirection.x * 0.2f;
			spawnPosition.y += shootDirection.y * 0.2f;

			//create the object in front of the player
			GameObject bullet = (GameObject)Instantiate (prefab, spawnPosition, Quaternion.identity);
			//apply the velocity in the shoot direction
			bullet.GetComponent<Rigidbody2D> ().velocity = shootDirection * bulletSpeed;
			Destroy (bullet, bulletLifetime);


			timer = 0;
		}
	}
}
