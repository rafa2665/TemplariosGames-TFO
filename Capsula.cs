using UnityEngine;
using System.Collections;

public class Capsula : MonoBehaviour {
	AudioSource som;
	GameObject hud;
	void Start()
	{
		som = gameObject.GetComponent<AudioSource> ();
		hud = GameObject.FindGameObjectWithTag("HUD");
	}
	void OnTriggerEnter(Collider outro)
	{
		if (outro.gameObject.tag == "Player")
		{
			if (hud.GetComponent<LIFE> ().getAneis() < 3)
			{
				hud.GetComponent<LIFE> ().setAneis (1);
			}
			som.Play ();
			Destroy (gameObject);
		}
		
	}

}
