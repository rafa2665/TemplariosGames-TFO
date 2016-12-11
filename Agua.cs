using UnityEngine;
using System.Collections;

public class Agua : MonoBehaviour {
	//O personagem perde 2 aneis de vida a cada 2 segundos dentro da agua acida.
	GameObject hud;
	void Start()
	{
		hud = GameObject.FindGameObjectWithTag ("HUD");
	}
	void OnCollisionStay(Collision outro)
	{
		if(outro.gameObject.tag == "Player")
		Invoke ("tempoParaMorte", 2f);
	}
	void OnTriggerStay(Collider outro)
	{
		if (outro.gameObject.tag == "Player")
		{
			Debug.Log ("AGUA");
			Invoke ("tempoParaMorte", 2f);
		}
	}
	void tempoParaMorte()
	{
		hud.GetComponent<LIFE> ().setAneis (-1);
	}
}
