using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Pontuacao : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textoPontuacao;
    private int pontos;

    public void AdicionarPontos (){
        this.pontos++;
        Debug.Log(this.pontos);
        this.textoPontuacao.text = this.pontos.ToString();
    }

    public void Reiniciar () {
        this.pontos = 0;
        this.textoPontuacao.text = this.pontos.ToString();
    }

}
