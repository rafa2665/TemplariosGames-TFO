using UnityEngine;
using System.Collections;

public class Flutuar : MonoBehaviour {
    float posicaoY;
    enum posicaoAtual { emBaixo, emCima };
    posicaoAtual posicao = posicaoAtual.emBaixo;

    void Start()
    {
        posicaoY = transform.position.y;
        transform.position = new Vector3(transform.position.x, posicaoY - 1.1f, transform.position.z);
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
        float forca = 0;
        switch (posicao)
        {
            case posicaoAtual.emBaixo:
                forca = Mathf.Lerp(forca, posicaoY + 1, Time.deltaTime);//mude de lerp para movetoward
                transform.Translate(0, forca, 0);
                break;
            case posicaoAtual.emCima:
                forca = Mathf.Lerp(forca, posicaoY - 1, Time.deltaTime);//mude de lerp para movetoward
                transform.Translate(0, forca, 0);
                break;
        }
    }
}
