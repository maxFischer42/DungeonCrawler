using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HP : MonoBehaviour {

	public float Hp;
	public float maxHp;
	public bool slashing;
	public PlayerAnimator PA;
	public Scrollbar Scroll;
	public Rigidbody2D Rig;


	void Update () {
		slashing = PA.swinging;
		Scroll.size = Hp / maxHp;
		if (Hp <= 0) {
			SceneManager.LoadScene (PlayerPrefs.GetString("level"));
			PlayerPrefs.SetInt ("Equip", 0);
		}
	}

	void OnCollisionEnter2D(Collision2D Coll)
	{
		Debug.Log ("Coll");
		if(Coll.gameObject.tag == "Hurt" && slashing == false)
		{
			Debug.Log ("Hurt");
			Hp -= 1;
			Rig.velocity = new Vector2 (Rig.velocity.x * -10, Rig.velocity.y * -10);
		}


	}

	void OnTriggerEnter2D(Collider2D Coll)
	{
		Debug.Log ("Coll");
		if(Coll.gameObject.tag == "Hurt" && slashing == false)
		{
			Debug.Log ("Hurt");
			Hp -= 1;
			//Rig.velocity = new Vector2 (Rig.velocity.x * -10, Rig.velocity.y * -10);
		}


	}




}
