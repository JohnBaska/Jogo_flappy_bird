using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    private float velocidade = 0.1f;

    // Start is called before the first frame update
    void Update()
    {
        this.transform.Translate(Vector3.left * this.velocidade);
    }
}
