using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;
using UnityStandardAssets.Cameras;

public class MudarCamera : MonoBehaviour {
	[SerializeField]
	GameObject cameraPrimeira,obj3peson,cameraOrigin,armaTela;

	bool modoPrimeira = true;
	// Update is called once per frame
	void Update () {
		TeclaDeTroca ();
		AtzLocal ();
		if (gameObject.GetComponent<Instrucoes> ().SemTexto () == false)
		{
			cameraPrimeira.transform.localPosition = new Vector3 (0, 0, 0);
		}
	}
	void TeclaDeTroca()
	{
		if (Input.GetKeyDown (KeyCode.V) && gameObject.GetComponent<Instrucoes>().SemTexto())
		{
			modoPrimeira = !modoPrimeira;
			AtivarModos ();				
		}
		if (Input.GetMouseButtonDown (1) && gameObject.GetComponent<Instrucoes>().SemTexto())
		{
			modoPrimeira = !modoPrimeira;
			AtivarModos ();	
		}
		else if (Input.GetMouseButtonUp (1) && gameObject.GetComponent<Instrucoes>().SemTexto())
		{
			modoPrimeira = !modoPrimeira;
			AtivarModos ();	
		}
	}
	void AtzLocal()
	{
		if (modoPrimeira  && gameObject.GetComponent<Instrucoes>().SemTexto())
		{
			obj3peson.transform.position = cameraOrigin.transform.position;
		}
	}
	void AtivarModos()
	{
		if (modoPrimeira)
		{
			cameraPrimeira.GetComponent<CharacterController>().enabled = true;
			cameraPrimeira.GetComponent<FirstPersonController>().enabled = true;
			cameraPrimeira.GetComponent<AutoCam>().enabled = false;
			obj3peson.SetActive(false);
			armaTela.SetActive(true);
			cameraPrimeira.tag = "Player";
			cameraOrigin.transform.localPosition = new Vector3 (0, 8, 0);
			//cameraPrimeira.transform.eulerAngles = new Vector3(transform.eulerAngles.x,obj3peson.transform.eulerAngles.y,transform.eulerAngles.z);
			//armaTela.SetActive(true);
		}
		else
		{
			cameraPrimeira.GetComponent<CharacterController>().enabled = false;
			cameraPrimeira.GetComponent<FirstPersonController>().enabled = false;
			cameraPrimeira.GetComponent<AutoCam>().enabled = true;
			obj3peson.SetActive(true);
			armaTela.SetActive(false);
			cameraPrimeira.tag = "Untagged";
			obj3peson.transform.localEulerAngles = new Vector3(/*transform.eulerAngles.x*/0,cameraPrimeira.transform.localEulerAngles.y,/*transform.eulerAngles.z*/0);
			cameraOrigin.transform.localPosition = new Vector3 (0, 2, -3);
			//armaTela.SetActive(false);
		}
	}
}
