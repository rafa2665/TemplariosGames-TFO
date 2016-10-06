using UnityEngine;
using System.Collections;

public class TrocarVisao : MonoBehaviour {//esse script vai no player
    Vector3 posicaoT, posicaoP;
    [SerializeField]
    Transform cam;
	// Use this for initialization
	void Start () {
        posicaoP = new Vector3(transform.position.x, transform.position.y + 0.5f, transform.position.z);//defina a posicao da primeira pessoa
        posicaoT = cam.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        ApertouMouse();
	}

    void ApertouMouse()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if (cam.transform.position == posicaoT)
                cam.transform.position = posicaoP;
        }

        else if (Input.GetMouseButtonUp(1))
        {
            if (cam.transform.position == posicaoP)
                cam.transform.position = posicaoT;
        }
    }
}
