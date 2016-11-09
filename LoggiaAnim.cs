using UnityEngine;
using System.Collections;

public class LoggiaAnim : MonoBehaviour {
	[SerializeField]
	bool chau,cintura,emPe,sentada;

	Animator anim;

	// Use this for initialization
	void Start () {
		anim = gameObject.GetComponent<Animator> ();
		anim.SetBool ("Cha", chau);
		anim.SetBool ("Cintura", cintura);
		anim.SetBool ("EmPe", emPe);
		anim.SetBool ("Sentada", sentada);
	
	}

}
