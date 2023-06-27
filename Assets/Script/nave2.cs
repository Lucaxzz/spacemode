using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nave2 : MonoBehaviour
{
    public float velocidade = 1.0f;
    public float reposicao = 18; 
    public Vector3 posicaoInicial ;
    // Start is called before the first frame update
    void Start()
    {
        posicaoInicial  = transform.position ;
    }

    // Update is called once per frame
    void Update()
    {
        float novoPosicao = Mathf.Repeat(Time.time * velocidade,reposicao);
        transform.position = posicaoInicial + Vector3.up * novoPosicao;
    }
}
