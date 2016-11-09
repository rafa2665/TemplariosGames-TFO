using UnityEngine;
using System.Collections;
//esse script deve ser colocado nas plataformas
//[RequireComponent(typeof(Rigidbody))]
public class Flutuar : MonoBehaviour
{
	/*float alturaMin;
	int forca = 60;
	Rigidbody rb;
	// Use this for initialization
	void Start()
	{
		//StartCoroutine(AlterarForca(5));
		alturaMin = transform.position.y - 0.5f;
		rb = GetComponent<Rigidbody>();
	}
	*/
	// Update is called once per frame
	void Update()
	{
		//Flutuando();
		//Girando();
		transform.eulerAngles += new Vector3(0, 60 * Time.deltaTime, 0);
	}
	/*
	void Flutuando()
	{
		if (transform.localPosition.y <= alturaMin && transform.position.y+5 > 6)//defina a altura minima do objeto
			rb.AddForce(0, forca, 0);

	}
	IEnumerator AlterarForca(int tempo)
	{
		//yield return new WaitForSeconds(tempo);
		forca = 10;
		//StartCoroutine(AlterarForca(5));
	}
	void Girando()//gira o objeto
	{
		transform.eulerAngles += new Vector3(0, forca * Time.deltaTime, 0);
	}
	*/
}
