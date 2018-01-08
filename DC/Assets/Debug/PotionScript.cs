using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionScript : MonoBehaviour {

	public Shoot PlayerShoot;
	public BombScript Bombs;



	void OnCollisionEnter2D(Collision2D Coll)
	{
		if (Coll.gameObject.tag == "Player") {
			PlayerShoot = Coll.gameObject.GetComponent<Shoot> ();
			Bombs = Coll.gameObject.GetComponent<BombScript> ();
			int select = PlayerPrefs.GetInt ("Equip");
			switch (select) {

			case 0:
				if (PlayerShoot.fireFuel != 1.0f) {
					PlayerShoot.fireFuel += 0.1f;
				}
				break;
			case 1:
				if (PlayerShoot.iceFuel != 1.0f) {
					PlayerShoot.iceFuel += 0.1f;
				}
				break;
			case 2:
				if (PlayerShoot.elecFuel != 1.0f) {
					PlayerShoot.elecFuel += 0.1f;
				}
				break;
			case 3:
				if (PlayerShoot.lightFuel != 1.0f) {
					PlayerShoot.lightFuel += 0.1f;
				}
				break;
			case 4:
				if (PlayerShoot.darkFuel != 1.0f) {
					PlayerShoot.darkFuel += 0.1f;
				}
				break;
			case 5:
				if (Bombs.Ammo != 1.0f) {
					Bombs.Ammo += 0.1f;
				}
				break;
			
			
			
			}

			Destroy (gameObject);
		}
	}

}
