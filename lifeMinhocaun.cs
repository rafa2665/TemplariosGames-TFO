using UnityEngine;
using System.Collections;

public class lifeMinhocaun : MonoBehaviour {
	[SerializeField]
	GameObject MinhocaunObj;
	void OnTriggerEnter(Collider outro)
	{
		if (outro.gameObject.tag == "Tiro") 
		{
			MinhocaunObj.GetComponent<Minhocaun> ().Setlife (0.5f);
		}
	}
}
