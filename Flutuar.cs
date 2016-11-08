using UnityEngine;
using System.Collections;
//esse script deve ser colocado nas plataformas
[RequireComponent(typeof(Rigidbody))]
public class Flutuar : MonoBehaviour
{
    float alturaMin;
    int forca = 1;
    Rigidbody rb;
    // Use this for initialization
    void Start()
    {
        StartCoroutine(AlterarForca(5));
        //forca = Random.Range(15, 21);
        alturaMin = transform.position.y - 1;
        rb = GetComponent<Rigidbody>();
        rb.mass = 0.03f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Flutuando();
        Girando();
    }

    void Flutuando()
    {
        if (transform.localPosition.y <= alturaMin)//defina a altura minima do objeto
            rb.AddRelativeForce(0, forca, 0);
    }

    IEnumerator AlterarForca(int tempo)
    {
        yield return new WaitForSeconds(tempo);
        //forca = Random.Range(15, 21);
        StartCoroutine(AlterarForca(5));
    }

    void Girando()//gira o objeto
    {
        transform.eulerAngles += new Vector3(0, forca, 0);
    }
}
