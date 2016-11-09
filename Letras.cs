using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Letras : MonoBehaviour {
	[SerializeField]
	Text objetivo1,objetivo2;
	[SerializeField]
	AudioSource clearSong;
	bool tempClear2 = true;
	string lt = ".",ot = ".",gt = ".",it = "",at = "";

	// Update is called once per frame
	void Update () {
		objetivo1.text = "Objetivo 1: " + lt + ot + gt + it + at;
		if (objetivo1.text == "Objetivo 1: LOGIA")
		{
			at = "A OK";
			clearSong.Play ();
		}
		if (objetivo2.text == "Objetivo 2: Ok" && tempClear2)
		{
			clearSong.Play ();
			tempClear2 = false;
		}
	}
	public void setclt()
	{
		lt = "L";
	}
	public void setcot()
	{
		ot = "O";
	}
	public void setcgt()
	{
		gt = "G";
	}
	public void setcit()
	{
		it = "I";
	}
	public void setcat()
	{
		at = "A";
	}
}
