using UnityEngine;
using System.Collections;

public class LetrasInd : MonoBehaviour {
	[SerializeField]
	bool l,o,g,i,a;
	[SerializeField]
	GameObject letrasPai;
	[SerializeField]
	AudioSource song;
	void OnTriggerEnter(Collider outro)
	{
		if (outro.gameObject.tag == "Player") 
		{
			if (l)
			{
				letrasPai.GetComponent<Letras> ().setclt ();
				song.Play ();
				Destroy (gameObject);
			}
			else if (o)
			{
				letrasPai.GetComponent<Letras> ().setcot ();
				song.Play ();
				Destroy (gameObject);
			}
			else if (g)
			{
				letrasPai.GetComponent<Letras> ().setcgt ();
				song.Play ();
				Destroy (gameObject);
			}
			else if (i)
			{
				letrasPai.GetComponent<Letras> ().setcit ();
				song.Play ();
				Destroy (gameObject);
			}
			else if (a)
			{
				letrasPai.GetComponent<Letras> ().setcat ();
				song.Play ();
				Destroy (gameObject);
			}
		}
	}
}
