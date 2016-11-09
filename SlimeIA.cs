using UnityEngine;
using System.Collections;

public class SlimeIA : MonoBehaviour {
	Animator anim;
	GameObject hud;
	float velocidade = 0.3f;
	[SerializeField]
	AudioSource slimeAtaque,slimeMov;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		hud = GameObject.FindGameObjectWithTag("HUD");
	}
	void OnTriggerStay(Collider outro)
	{
		if (transform.localScale.x == 1f)
		{
			velocidade = 0.5f;
		}
		else if(transform.localScale.x == 0.5f)
		{
			velocidade = 0.8f;
		}	
		if (outro.gameObject.tag == "Player")
		{
			transform.position = Vector3.Lerp (transform.position, GameObject.FindGameObjectWithTag("Player").transform.position, Time.deltaTime * velocidade);
			transform.LookAt (GameObject.FindGameObjectWithTag ("Player").transform);
			if (slimeMov.isPlaying == false)
			{
				slimeMov.Play ();
			}
		}
	}
	void OnTriggerExit(Collider outro)
	{
		if (outro.gameObject.tag == "Player")
		{
			slimeMov.Stop();
		}
	}
	void OnCollisionEnter(Collision outro)
	{
		if (outro.gameObject.tag == "Player")
		{
			hud.GetComponent<LIFE> ().setAneis (-1);
			anim.SetTrigger ("Ataque");
			slimeAtaque.Play ();
		}
	}
}
