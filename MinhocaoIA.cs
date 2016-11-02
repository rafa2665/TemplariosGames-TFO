using UnityEngine;
using System.Collections;

public class MinhocaoIA : MonoBehaviour {//coloque um SphereCollider no minhocao de raio 6 e esse script no minhocao
	int anim;

	void OnTriggerStay(Collider objeto) {
		if (objeto.gameObject.name == "FPSController" || objeto.gameObject.name == "ThirdPersonController") {
			Alerta ();
		}
	}

	void OnTriggerEnter(Collider objeto) {
		if (objeto.gameObject.name == "FPSController" || objeto.gameObject.name == "ThirdPersonController")
			InvokeRepeating ("RandomizarAnimacao", 0.1f, 1);//aqui chama a funcao RandomizarAnimacao a cada 6 seg
	}

	void OnTriggerExit(Collider objeto) {
		if (objeto.gameObject.name == "FPSController" || objeto.gameObject.name == "ThirdPersonController") {
			Hiberna ();
			CancelInvoke ("RandomizarAnimacao");
		}
	}

	void Alerta() {//aqui coloca animacoes e acoes de atacando ou defendendo ataques
		print ("Alertou!!");
		/*if (anim == 1)//if anim==1 faz animacao de ataque 1 || defesa 1
		 * fazisso
		if (anim == 2)//if anim==2 faz animacao de ataque 2 || defesa 2
		fazisso
		*/
	}

	void Hiberna() {//aqui pode colocar animacao de parado
		print ("Hibernou!!");
	}

	void RandomizarAnimacao() {
		anim = Random.Range (1, 3);
		print ("Randomizar");
	}
}