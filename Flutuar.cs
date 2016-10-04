using UnityEngine;
using System.Collections;
//esse script deve ser colocado nas plataformas
[RequireComponent(typeof(Rigidbody))]
public class Flutuar : MonoBehaviour
{
    [SerializeField][Range(1, 100)] int velocidade;
    Rigidbody rb;
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Flutuando();
        Girando();
    }

    void Flutuando()
    {
        if (transform.localPosition.y >= 3)
        {//defina a altura maxima do objeto
            print("3");
            rb.AddRelativeForce(-Vector3.up * velocidade);
        }
        else if (transform.localPosition.y <= -1)
        {//defina a altura minima do objeto
            print("-3");
            rb.AddRelativeForce(Vector3.up * velocidade);
        }
    }

    void Girando()//gira o objeto
    {
        transform.localRotation = Quaternion.Euler(Vector3.up * Time.fixedTime);
    }
}
