using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randomize : MonoBehaviour
{


	public GameObject[] buildingBlocks;
	public Vector2 LowRange;
	public Vector2 HighRange;
	public Vector2 ExitRange;
	public Vector2 SpawnRange;
	private bool placeSpawn = false;
	private bool placeExit = false;

	public GameObject Player;

	void Start ()
	{

		var numOfBlocks = buildingBlocks.Length;

		float x = LowRange.x;
		float y = LowRange.y;

		for (float yi = 0; yi <= HighRange.y; yi++) {
			for (float i = 0; i <= HighRange.x; i++) {
				int randomObj = Random.Range (2, numOfBlocks);
				if(x == ExitRange.x && y == ExitRange.y)
				{
					Instantiate (buildingBlocks [0], ExitRange, Quaternion.identity);
				}
				if(x == SpawnRange.x && y == SpawnRange.y)
				{
					Instantiate (buildingBlocks [1], SpawnRange, Quaternion.identity);
				}

			
					int randomObj2 = Random.Range (2, numOfBlocks);
				Vector2 testLoc = new Vector2 (x, y);
					if(testLoc != ExitRange || testLoc != SpawnRange){
					Instantiate (buildingBlocks [randomObj2], new Vector2 (x, y), Quaternion.identity);
					}


				if (randomObj == 2) {
					placeSpawn = true;
				}
				if (randomObj == 1) {
					placeExit = true;
				}

				x++;
			}
			x = LowRange.x;
			y++;
		}

		Player.transform.position = SpawnRange;

	}
	

}
