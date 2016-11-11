using UnityEngine;
using System.Collections;
[RequireComponent(typeof(Rigidbody))]
public class Nave : MonoBehaviour {
    Rigidbody rb;
    float angle;
    [SerializeField] GameObject[] propulsor;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        angle = 0;
	}
	
	// Update is called once per frame
	void Update () {
        Controles();
	}

    void Controles()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            angle = Mathf.MoveTowards(angle, 180, Time.deltaTime*90);
            for (int i = 0; i < propulsor.Length; i++)
            {
                propulsor[i].transform.localRotation = Quaternion.Euler(angle, 0, 0);
                propulsor[i].GetComponent<ParticleSystem>().enableEmission = true;
            }
               rb.AddRelativeForce(Vector3.forward * 100);
        }
        else if (Input.GetKey(KeyCode.LeftControl))
        {
            angle = Mathf.MoveTowards(angle, 0, Time.deltaTime*90);
            for (int i = 0; i < propulsor.Length; i++)
            {
                propulsor[i].transform.localRotation = Quaternion.Euler(angle, 0, 0);
                propulsor[i].GetComponent<ParticleSystem>().enableEmission = true;
            }
            rb.AddRelativeForce(Vector3.forward * -100);
        }

        if (Input.GetKeyUp(KeyCode.LeftControl) || Input.GetKeyUp(KeyCode.Space))
        {
            for (int i = 0; i < propulsor.Length; i++)
            {
                propulsor[i].GetComponent<ParticleSystem>().enableEmission = false;
            }
            
        }
        
        //rotacao em Z
        if (Input.GetKey(KeyCode.Q))
            transform.Rotate(Vector3.forward * 5);
        else if (Input.GetKey(KeyCode.E))
            transform.Rotate(Vector3.forward * -5);
        
        //rotacao em X e Y
        transform.Rotate(Vector3.right * Input.GetAxisRaw("Vertical") * 2);
        transform.Rotate(Vector3.up * Input.GetAxisRaw("Horizontal") * 2);
    }
}
