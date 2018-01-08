using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class WinCondition : MonoBehaviour {

	public bool exit = false;
	public string Level;
	void OnCollisionEnter2D(Collision2D Coll)
	{
		if (Coll.gameObject.tag == "Player") {

			if (exit != true) {
				PlayerPrefs.SetString ("level", Level);
				SceneManager.LoadScene (Level);
			} else {
				Application.Quit ();
			}
		}
	}
}
