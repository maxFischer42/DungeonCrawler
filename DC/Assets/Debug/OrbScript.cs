using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbScript : MonoBehaviour {

	float timer = 0.0f;
	public GameObject GhostToSpawn;
	public float timeToSpawn = 4.0f;
	public int max = 1;
	int current;
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if (timer > timeToSpawn && max > current) {
			GameObject var = Instantiate (GhostToSpawn, transform.position, Quaternion.identity);
			var.transform.SetParent (transform);
			timer = 0;
			current++;
		}
	}
}
