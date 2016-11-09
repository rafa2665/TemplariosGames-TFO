using UnityEngine;
using System.Collections;

public class RotMinhocaun : MonoBehaviour {
	void OnTriggerStay(Collider outro)
	{
		if (outro.gameObject.tag == "Player") 
		{
			transform.LookAt (new Vector3(outro.transform.position.x+4f,transform.position.y,outro.transform.position.z));
		}
	}
}
