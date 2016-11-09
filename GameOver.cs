using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameOver : MonoBehaviour {
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Return))
		{
			SceneManager.LoadScene("MENU");
		}
	}

	public void ClicouNobut()
	{
		SceneManager.LoadScene("MENU");
	}
}
