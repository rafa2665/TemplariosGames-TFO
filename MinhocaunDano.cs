using UnityEngine;
using System.Collections;

public class MinhocaunDano : MonoBehaviour {
	GameObject hud;
	// Use this for initialization
	void Start () {
		hud = GameObject.FindGameObjectWithTag("HUD");
	}
	void OnTriggerEnter()
	{
		hud.GetComponent<LIFE> ().setAneis (-1);
	}
}
