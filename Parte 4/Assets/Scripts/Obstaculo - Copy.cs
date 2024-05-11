using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    private float velocidade = 0.1f;
    private float variacaoDaPosicaoY = 1f;
    
    private void Awake()
    {
        this.transform.Translate(Vector3.up * Random.Range(-variacaoDaPosicaoY, variacaoDaPosicaoY));
    }

    // Start is called before the first frame update
    void Update()
    {
        this.transform.Translate(Vector3.left * this.velocidade * Time.timeScale);
    }

    private void OnTriggerEnter2D(Collider2D outro)
    {
        GameObject.Destroy(this.gameObject);
    }



}
