using UnityEngine;
using System.Collections;

public class Laser : MonoBehaviour {//Esse script deve ser colocado na arma
	[SerializeField] Color corLaser = Color.blue;
	[SerializeField] int distanciaDoLaser;
	[SerializeField] float larguraInicial, larguraFinal;
	GameObject luzColisao;
	Vector3 posicLuz;
	// Use this for initialization
	void Start () {
		luzColisao = new GameObject ();//cria um obj vazio
		luzColisao.AddComponent<Light> ();//adiciona o componente luz
		luzColisao.GetComponent<Light> ().intensity = 8;//muda intensidade da luz
		luzColisao.GetComponent<Light> ().bounceIntensity = 8;//muda outra intensidade
		luzColisao.GetComponent<Light> ().range = larguraFinal * 2;//tamanho da luz
		luzColisao.GetComponent<Light> ().color = corLaser;//da cor a luz
		posicLuz = new Vector3(0, 0, larguraFinal);
		LineRenderer line = gameObject.AddComponent<LineRenderer> ();//desenha linha para simular o laser
		line.material = new Material (Shader.Find ("Particles/Additive"));
		line.SetColors (corLaser, corLaser);
		line.SetWidth (larguraInicial, larguraFinal);
		line.SetVertexCount (2);
	}

	void Update () {
		Vector3 pontoFinalDoLaser = transform.position + transform.forward * distanciaDoLaser;
		RaycastHit pontoDeColisao;
		if (Physics.Raycast (transform.position, transform.forward, out pontoDeColisao, distanciaDoLaser)) {//verificando se esta colidindo com algo
			GetComponent<LineRenderer> ().SetPosition (0, transform.position);
			GetComponent<LineRenderer> ().SetPosition (1, pontoDeColisao.point);
			luzColisao.transform.position = pontoDeColisao.point - posicLuz;
		} else {
			GetComponent<LineRenderer> ().SetPosition (0, transform.position);
			GetComponent<LineRenderer> ().SetPosition (1, pontoFinalDoLaser);
			luzColisao.transform.position = pontoFinalDoLaser;
		}
	}
}
