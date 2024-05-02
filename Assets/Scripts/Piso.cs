using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piso : MonoBehaviour
{
    [SerializeField] private float velocidade = 0.1f;
    private Vector3 posicaoInicial;
    private float tamanhoDaImagem;
    
    void Awake (){
        this.posicaoInicial = this.transform.position;
        this.tamanhoDaImagem = this.GetComponent<SpriteRenderer>().size.x;
    }
    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector3.left*this.velocidade);
    }
}
