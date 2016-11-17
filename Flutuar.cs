using UnityEngine;
using System.Collections;

public class Flutuar : MonoBehaviour
{
    float posicaoY;
    enum posicaoAtual { emBaixo, emCima };
    posicaoAtual posicao = posicaoAtual.emBaixo;
    float forca;
    void Start()
    {
        posicaoY = transform.position.y;
        transform.position = new Vector3(transform.position.x, posicaoY - 1.1f, transform.position.z);
        forca = 0;
    }

    void Update()
    {
        Flutuando();
    }

    void Flutuando()
    {
        if (transform.position.y < posicaoY - 1)
          posicao = posicaoAtual.emBaixo;
        else if (transform.position.y > posicaoY + 1)
          posicao = posicaoAtual.emCima;
        Debug.Log(forca);
        switch (posicao)
           {
               case posicaoAtual.emBaixo:
                   forca = Mathf.Lerp(forca, posicaoY + 1, 0.01f);
                   transform.Translate(0, forca, 0);
                   break;
               case posicaoAtual.emCima:
                   forca = Mathf.Lerp(forca, posicaoY - 1, 0.01f);
                   transform.Translate(0, forca, 0);
                   break;
           }
    }
}
