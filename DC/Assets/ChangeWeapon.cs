using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeWeapon : MonoBehaviour {

	public Image Image;
	public Sprite Fire;
	public Sprite Ice;
	public Sprite Elec;
	public Sprite Light;
	public Sprite Dark;
	public Sprite Bomb;
	public Sprite Sword;
	public int select = 0;







	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetAxis ("Mouse ScrollWheel") > 0) {
			select++;
			if (select == 7) {
				select = 0;
			}
		}
		else if (Input.GetAxis ("Mouse ScrollWheel") < 0) {
			select--;
			if (select == -1) {
				select = 6;
			}
		}
		PlayerPrefs.SetInt ("Equip", select);
		switch (select) {

		case 0:
			Image.sprite = Fire;
			break;
		case 1:
			Image.sprite = Ice;
			break;
		case 2:
			Image.sprite = Elec;
			break;
		case 3:
			Image.sprite = Light;
			break;
		case 4:
			Image.sprite = Dark;
			break;
		case 5:
			Image.sprite = Bomb;
			break;
		case 6:
			Image.sprite = Sword;
			break;
		}




	}


}
