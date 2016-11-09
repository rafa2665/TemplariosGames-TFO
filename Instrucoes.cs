using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Instrucoes : MonoBehaviour {
	[SerializeField]
	Text texto1;
	[SerializeField]
	GameObject panel;

	bool semTextosNaTela = false;

	// Use this for initialization
	void Start () {
		Saudacoes ();
	
	}
	void Saudacoes()
	{
		texto1.text = "Bem Vindo ao TFO Beta agradecemos por jogar!";
		panel.SetActive (true);
		Invoke ("Instrucoes1", 4);
	}
	void Instrucoes1()
	{
		texto1.text = "Nessa Beta você ataca somente em 1ª pessoa. Utilize a tecla V para efetuar a troca de visão.";
		panel.SetActive (true);
		Invoke ("Objetivo1", 6);
	}
	void Objetivo1()
	{
		texto1.text = "Objetivo1: Coletar a palavra Logia para comprender a lingua local. \n Objetivo2: Investigar o estranho rugido.";
		panel.SetActive (true);
		Invoke ("Sumir", 8);
	}
	void Sumir()
	{
		texto1.text = "";
		semTextosNaTela = true;
		panel.SetActive (false);
	}
	public bool SemTexto()
	{
		return semTextosNaTela;
	}
}
