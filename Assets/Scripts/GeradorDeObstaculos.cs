using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorDeObstaculos : MonoBehaviour
{
    [SerializeField] private float tempoParaGerar;
    [SerializeField] private GameObject obstaculo;
    private float cronometro;
    
    // Start is called before the first frame update
    void Awake()
    {
        this.cronometro = this.tempoParaGerar;
    }

    // Update is called once per frame
    void Update()
    {
        this.cronometro = this.cronometro - Time.deltaTime;
        
        if (this.cronometro < 0){
            print (this.obstaculo.transform.position);
            GameObject.Instantiate(this.obstaculo, this.transform.position, Quaternion.identity);
            this.cronometro = this.tempoParaGerar;

        }
    }
}
