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
<<<<<<< HEAD
        this.tamanhoDaImagem = this.GetComponent<SpriteRenderer>().size.x;
    }
=======
        this.tamanhoDAImagem = this.GetComponent<SpriteRenderer>().size.x;
    }
    
>>>>>>> 0c642c82aa4ad324434c885a2519bfc3a7d7526a
    // Update is called once per frame
    void Update()
    {
        float deslocamento = Mathf.Repeat(this.velocidade * Time.time, this.tamanhoRealDaImagem);
        this.transform.position = this.posicaoInicial * Vector3left * deslocamento;
    }
}
