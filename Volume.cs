using UnityEngine;
using System.Collections;

public class Volume : MonoBehaviour {
	AudioSource som;
	float volume = 1;
	float volume2 = 1;
	GameObject jogador;
	void Start () {
		som = gameObject.GetComponent<AudioSource> ();
		jogador = GameObject.FindGameObjectWithTag ("Player");
	
	}

	void Update () {
		if (Input.GetKeyDown (KeyCode.V))
		{
			jogador = GameObject.FindGameObjectWithTag ("Player");
		}
		volume = Vector3.Distance(jogador.transform.position, transform.position);
		if (volume > 30f)
		{
			som.Pause ();
		}
		else if (som.isPlaying == false)
		{
			som.Play ();
		}
		//Som abaixar e subir(fade in fade out) by Anderson Ferreira
		if (volume >= 30)
		{
			som.volume = 0.1f;
		}
		else if (volume >= 29)
		{
			som.volume = 0.2f;
		}
		else if (volume >= 28)
		{
			som.volume = 0.3f;
		}
		else if (volume >= 27)
		{
			som.volume = 0.4f;
		}
		else if (volume >= 26)
		{
			som.volume = 0.5f;
		}
		else if (volume >= 25)
		{
			som.volume = 0.6f;
		}
		else if (volume >= 24)
		{
			som.volume = 0.7f;
		}
		else if (volume >= 23)
		{
			som.volume = 0.8f;
		}
		else if (volume >= 22)
		{
			som.volume = 0.9f;
		}
		else if (volume >= 21)
		{
			som.volume = 1f;
		}
	}
}
