using UnityEngine;
using System.Collections;
//esse script deve ser colocado nas plataformas
[RequireComponent(typeof(Rigidbody))]
public class Flutuar : MonoBehaviour
{
    float alturaMin;
    int forca = 20;
    Rigidbody rb;
    // Use this for initialization
    void Start()
    {
        StartCoroutine(AlterarForca(5));
        forca = Random.Range(15, 21);
        alturaMin = transform.position.y - 1;
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
        if (transform.localPosition.y <= alturaMin)//defina a altura minima do objeto
            rb.AddRelativeForce(0, 0, forca);
    }

    IEnumerator AlterarForca(int tempo)
    {
        yield return new WaitForSeconds(tempo);
        forca = Random.Range(15, 21);
        StartCoroutine(AlterarForca(5));
    }

    void Girando()//gira o objeto
    {
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, 0.1f * forca, transform.eulerAngles.z);
    }
}
