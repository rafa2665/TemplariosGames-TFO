using UnityEngine;
using System.Collections;

public class Caixa : MonoBehaviour {
	Animator animacao;
	AudioSource som;
	[SerializeField]
	GameObject capsula;
	[SerializeField]
	BoxCollider boxDesativar;

	// Use this for initialization
	void Start () {
		animacao = gameObject.GetComponent<Animator> ();
		som = gameObject.GetComponent<AudioSource> ();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter (Collider outro)
	{
		if (outro.gameObject.tag == "Tiro")
		{
			animacao.SetBool ("Abrir", true);
			boxDesativar.enabled = false;
			som.Play ();
			Instantiate (capsula, transform.position, Quaternion.identity);
			Destroy (gameObject, 4f);
			Destroy (outro.gameObject);
		}
	}
}
