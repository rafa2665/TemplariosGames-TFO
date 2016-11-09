using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Loading : MonoBehaviour {
	/*
	[Header("Nome Da Cena a Ser Carregada")]
	[SerializeField]
	string nomeDaCena;
	[Header("Texto do Carregamento")]
	[SerializeField]
	string textoLoad = "Carregando...";
	[Space(10)]
	[SerializeField]
	Texture texturaFundo,barraDeProgresso;
	[SerializeField]
	Color corTexto = Color.white;
	[SerializeField]
	Font fonte;
	[Space(10)]
	[Range(0.5f,3.0f)]
	[SerializeField]
	float tamDoTexto = 1.5f;
	[Range(1,10)]
	[SerializeField]
	int larguraDaBarra = 8,alturaDaBarra = 2;
	[Range(-4.5f,4.5f)]
	[SerializeField]
	float deslocarBarra = 4f;
	*/

	int progresso = 50;
	[SerializeField]
	GameObject barra;
	void Start () {
		StartCoroutine ("CenaDeCarregamento");
	
	}
	
	// Update is called once per frame
	void Update () {
		//StartCoroutine ("CenaDeCarregamento");
		barra.transform.localScale = new Vector3 (progresso/100, 1, 1);
		barra.transform.localScale = new Vector3 (progresso/100f, 1, 1);
	
	}
	IEnumerator CenaDeCarregamento()
	{
		AsyncOperation carregamento = SceneManager.LoadSceneAsync ("Novo Jogo",LoadSceneMode.Single);
		while (!carregamento.isDone)
		{
			progresso = (int)(carregamento.progress * 100);
			yield return null;
		}
	}
}
