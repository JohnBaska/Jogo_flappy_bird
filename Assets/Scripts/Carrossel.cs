using System.Collections;
using System.Collections.Generic;
using UnityEngine;

<<<<<<< HEAD
public class Carrossel : MonoBehaviour
{
    [SerializeField]private float velocidade;

    private Vector3 posicaoInicial;
    private float tamanhoRealDaImagem;

    private void Awake()
    {
        this.posicaoInicial = this.transform.position;
        float tamanhoDaImagem = this.GetComponent<SpriteRenderer>().size.x;
        float escala = this.transform.localScale.x;
        this.tamanhoRealDaImagem = tamanhoDaImagem * escala;
    }
    
    void Update()
    {
        float deslocamento = Mathf.Repeat(this.velocidade * Time.time, this.tamanhoRealDaImagem);
        this.transform.position = this.posicaoInicial + Vector3.left * deslocamento;
    }
}
=======
public class Piso : MonoBehaviour
{
    [SerializeField] private float velocidade = 0.1f;
    private Vector3 posicaoInicial;
    private float tamanhoDaImagem;
    
    void Awake (){
        this.posicaoInicial = this.transform.position;
        this.tamanhoDAImagem = this.GetComponent<SpriteRenderer>().size.x;
        float escala = this.transform.localScale.x;
        this.tamanhoRealDaImagem = tamanhoImagem * escala;
    }
    
    // Update is called once per frame
    void Update()
    {
        float deslocamento = Mathf.Repeat(this.velocidade * Time.time, this.tamanhoRealDaImagem);
        this.transform.position = this.posicaoInicial * Vector3left * deslocamento;
    }
}
>>>>>>> 0c642c82aa4ad324434c885a2519bfc3a7d7526a
