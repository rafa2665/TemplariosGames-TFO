using UnityEngine;
using System.Collections;

public class TiroSumir : MonoBehaviour {
	[SerializeField]
	GameObject balaEmiter;
	void OnCollisionEnter()
	{
		Instantiate (balaEmiter, transform.position, Quaternion.identity);
		Destroy (gameObject);
	}
}
