using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class StartMenu : MonoBehaviour {
	[SerializeField]
	GameObject nave,creditos,logo,novogame,fogo;

	Rigidbody naveRB;

	bool iniciou = false;

	[SerializeField]
	GameObject camReference;
	Vector3 posInicialCam;

	[SerializeField]
	AudioSource rocketLauncherEngine;

	void Start()
	{
		naveRB = nave.GetComponent<Rigidbody>();
		posInicialCam = camReference.transform.position;
	}

	void Update () {
		if (iniciou)
		{
			naveRB.AddRelativeForce(0,0,150);
			rocketLauncherEngine.pitch = Mathf.Lerp(rocketLauncherEngine.pitch, 3, Time.deltaTime/10);
		
		}
	
	}
	void MudarCena()
	{
		SceneManager.LoadScene ("Cena1");
	}
	public void StartTFO()
	{
		fogo.SetActive (true);
		iniciou = true;
		creditos.SetActive (false);
		logo.SetActive (false);
		novogame.SetActive (false);
		StartCoroutine ("CameraShake");
		Invoke ("MudarCena", 8f);
	}

	IEnumerator CameraShake()
	{
		while (true) {
			float rx = Random.Range (-0.05f, 0.05f);
			float ry = Random.Range (-0.05f, 0.05f);
			camReference.transform.position = new Vector3 (rx, ry, 0);
			yield return new WaitForSeconds (0.05f);
			rx = Random.Range (-0.05f, 0.05f);
			ry = Random.Range (-0.05f, 0.05f);
			camReference.transform.position = new Vector3 (rx, ry, 0);
			yield return new WaitForSeconds (0.05f);
			rx = Random.Range (-0.05f, 0.05f);
			ry = Random.Range (-0.05f, 0.05f);
			camReference.transform.position = new Vector3 (rx, ry, 0);
			yield return new WaitForSeconds (0.05f);
			camReference.transform.position = posInicialCam;
		}

	}
}
