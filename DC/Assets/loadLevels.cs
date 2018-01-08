using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadLevels : MonoBehaviour {


	public void levOne()
	{
		PlayerPrefs.SetString ("level", "debug");
		SceneManager.LoadScene ("debug");
	}

	public void levTwo()
	{
		PlayerPrefs.SetString ("level", "lev2");
		SceneManager.LoadScene ("lev2");
	}

	public void levThree()
	{
		PlayerPrefs.SetString ("level", "lev3");
		SceneManager.LoadScene ("lev3");
	}

	public void levFour()
	{
		PlayerPrefs.SetString ("level", "lev4");
		SceneManager.LoadScene ("lev4");
	}

	public void exit()
	{
		Application.Quit ();
	}
}
