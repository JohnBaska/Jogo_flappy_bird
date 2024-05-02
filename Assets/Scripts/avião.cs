using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aviao : MonoBehaviour
{
	Rigidbody2D fisica;
	[Serialize] private float forca = 6;
	private Diretor diretor;
	private Vector3 posicaoInicial;

	void Awake()
	{
		this.posicaoInicial = this.transform.position;
    	this.fisica = this.GetComponent<Rigidbody2D>();
	}

	private void Start()
    {
        this.diretor = GameObject.FindObjectOfType<Diretor>();  // Coletar um objeto o qual está em outro objeto
    } 

	// Update is called once per frame
	void Update()
	{
    	if(Input.GetButtonDown("Fire1") || Input.GetButtonDown("Jump"))
    	{
        	this.Impulsionar();
    	}
	}

	void Impulsionar()
	{
		this.fisica.velocity = Vector2.zero;
    	this.fisica.AddForce(Vector2.up * this.forca, ForceMode2D.Impulse);
	}

	private void OnCollisionenter2D(Collision colisao){
		this.fisica.simulated = false;
		this.diretor.FinalizarJogo();
	}

	public void Reiniciar()
    {
        this.transform.position = this.posicaoInicial;
        this.fisica.simulated = true;
    }
}

