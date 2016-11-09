using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Video1 : MonoBehaviour {
	void Start () {
		((MovieTexture)GetComponent<Renderer>().material.mainTexture).Play();
	
	}
	void Update()
	{
		if(((MovieTexture)GetComponent<Renderer>().material.mainTexture).isPlaying == false)
		{
			SceneManager.LoadScene ("Load");
		}
	}
}
