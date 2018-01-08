using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {

	public GameObject Fire;
	public GameObject Ice;
	public GameObject Elec;
	public GameObject Light;
	public GameObject Dark;

	public float fireFuel = 1.0f;
	public float iceFuel = 1.0f;
	public float elecFuel = 1.0f;
	public float lightFuel = 1.0f;
	public float darkFuel = 1.0f;

	private GameObject prefab;
	public float bulletSpeed = 10f;
	public float bulletLifetime = 1.0f;
	public float shootDelay = 1.0f;
	private float timer = 0;

	private float currentFuel;
	// Use this for initialization
	void Start () {
		timer = shootDelay;
	}
	
	// Update is called once per frame
	void Update () {

		int selected;
		selected = PlayerPrefs.GetInt ("Equip");

		switch (selected) {

		case 0:
			prefab = Fire;
			currentFuel = fireFuel;
			break;
		case 1:
			currentFuel = iceFuel;
			prefab = Ice;
			break;
		case 2:
			currentFuel = elecFuel;
			prefab = Elec;
			break;
		case 3:
			currentFuel = lightFuel;
			prefab = Light;
			break;
		case 4:
			currentFuel = darkFuel;
			prefab = Dark;
			break;
		}






		timer += Time.deltaTime;
		if (Input.GetButtonDown ("Fire1") && timer >= shootDelay && currentFuel > 0.0f) {
			//get the mouse position
			var mousePosition = Input.mousePosition;
			//convert the mouse position from pixels to x,y values in the game
			mousePosition = Camera.main.ScreenToWorldPoint (mousePosition);
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

			switch (selected) {

			case 0:
				fireFuel -= 0.1f;
				break;
			case 1:
				iceFuel -= 0.1f;
				break;
			case 2:
				elecFuel -= 0.1f;
				break;
			case 3:
				lightFuel -= 0.1f;
				break;
			case 4:
				darkFuel -= 0.1f;
				break;
			}
			timer = 0;
		}
	}
}
