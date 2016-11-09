using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class PularCustCene : MonoBehaviour {
	[SerializeField]
	string 	cena;
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Return))
		{
			SceneManager.LoadScene(cena);
		}
	}
}
