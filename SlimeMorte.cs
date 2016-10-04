using UnityEngine;
using System.Collections;

public class SlimeMorte : MonoBehaviour {
    [SerializeField]
    GameObject slime;

    void OnTriggerEnter(Collider outro)
    {
        GameObject novoSlime = slime;
        Instantiate(novoSlime, transform.position, Quaternion.identity);
        novoSlime.GetComponent<Transform>().localScale = (transform.localScale / 2);
        Destroy(gameObject, 0.001f);
    }
}
