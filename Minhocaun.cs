using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Minhocaun : MonoBehaviour {
	Animator anim;
	[SerializeField]
	GameObject lifeBarMinhocaun,naoSairDaBatalha,textMinho,lifeOrigin,contorno,paiGeral,morto;
	[SerializeField]
	Text objetivo2;
	bool som = true;

	[SerializeField]
	ParticleSystem acido;

	ParticleSystem.EmissionModule em1;
	// Use this for initialization

	[SerializeField]
	AnimationEvent ataque1;

	AudioSource roar;

	void Start () {
		anim = gameObject.GetComponent<Animator> ();
		roar = gameObject.GetComponent<AudioSource> ();
		em1 = acido.emission;
	}
	
	// Update is called once per frame
	void Update () {
		/*if(anim.animation["Armature|Ataque1_0"].time == 18)
		{
			Debug.Log ("Animou!");
		}*/
	}
	void OnTriggerEnter(Collider outro)
	{
		if (outro.gameObject.tag == "Player") 
		{
			anim.SetBool ("Ataque2", true);
			lifeBarMinhocaun.SetActive (true);
			naoSairDaBatalha.SetActive (true);
			textMinho.SetActive (true);
			contorno.SetActive (true);
			if (som)
			{
				acido.gameObject.GetComponent<AudioSource> ().Play ();
				som = false;
			}
			//acido.SetActive (true);
		}
	}
	public void Setlife(float valor)
	{
		if (lifeOrigin.transform.localScale.x > 0)
		{
			lifeOrigin.transform.localScale -= new Vector3 (valor, 0, 0);
		}
		else
		{
			objetivo2.text = "Objetivo 2: Ok";
			morto.SetActive (true);
			anim.SetBool ("Ataque2", false);
			lifeBarMinhocaun.SetActive (false);
			naoSairDaBatalha.SetActive (false);
			textMinho.SetActive (false);
			contorno.SetActive (false);
			//acido.SetActive (false);
			Destroy (lifeBarMinhocaun);
			Destroy (contorno);
			Destroy (textMinho);
			Destroy (naoSairDaBatalha);
			Destroy (paiGeral);
		}
	}

	public void BocaAberta()
	{
		em1.rate = new ParticleSystem.MinMaxCurve (200);
		roar.Play ();
	}

	public void BocaFechada()
	{
		em1.rate = new ParticleSystem.MinMaxCurve (0);
	}
}
