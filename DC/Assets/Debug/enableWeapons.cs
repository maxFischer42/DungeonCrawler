using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enableWeapons : MonoBehaviour {

	public BombScript Bomb;
	public SwordSlash Sword;
	private int selected;
	private float fuel = 1.0f;
	public Scrollbar Scroll;
	public Shoot Magic;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		selected = PlayerPrefs.GetInt ("Equip");

		switch (selected) {

		case 0:
			fuel = Magic.fireFuel;
			Sword.enabled = false;
			Magic.enabled = true;
			break;
		case 1:
			fuel = Magic.iceFuel;
			break;
		case 2:
			fuel = Magic.elecFuel;
			break;
		case 3:
			fuel = Magic.lightFuel;
			break;
		case 4:
			Magic.enabled = true;
			Bomb.enabled = false;
			fuel = Magic.darkFuel;
			break;
		case 5:
			Magic.enabled = false;
			Bomb.enabled = true;
			fuel = Bomb.Ammo;
			Sword.enabled = false;
			break;
		case 6:
			Magic.enabled = false;
			Bomb.enabled = false;
			Sword.enabled = true;
			break;
		}
		Scroll.size = fuel;


	}
}
