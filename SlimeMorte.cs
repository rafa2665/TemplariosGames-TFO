using UnityEngine;
using System.Collections;

public class SlimeMorte : MonoBehaviour {
	bool pode;
	[SerializeField]
	GameObject slime;
	[SerializeField]
	SphereCollider areaTam;
	void Start()
	{//massa da gosma = 1 e massa do player = 10, altere no rigidbody
		pode = false;
		//gameObject.GetComponent<Animator> ().SetTrigger ("Surgiu");
		//print("pode = " + pode);
		transform.localScale = new Vector3(transform.localScale.x / 2, transform.localScale.y / 2, transform.localScale.z / 2);
		StartCoroutine("PodeDividir");
		areaTam.radius *= 2;
	}
	void OnCollisionEnter(Collision outro)
	{
		if (pode)
		{
			if (outro.gameObject.tag == "Tiro")
			{
				StartCoroutine("PodeDividir");
				if (transform.localScale.x > 0.25 && transform.localScale.y > 0.25 && transform.localScale.z > 0.25)
				{
					GameObject novoSlime1 = slime;
					GameObject novoSlime2 = slime;
					Instantiate(novoSlime2, new Vector3(transform.position.x + 2, transform.position.y + 1, transform.position.z + -2), Quaternion.identity);
					Instantiate(novoSlime1, new Vector3(transform.position.x + -2, transform.position.y + 1, transform.position.z + 2), Quaternion.identity);
					Destroy(gameObject, 0.01f);
				}

				else if (transform.localScale.x == 0.25 && transform.localScale.y == 0.25 && transform.localScale.z == 0.25)
				{
					Debug.Log("Morreu!");
					Destroy(gameObject, 0.00001f);
				}
				Destroy (outro.gameObject);
			}
		}
	}
	IEnumerator PodeDividir()
	{
		yield return new WaitForSeconds(1);
		pode = true;
	}
}
