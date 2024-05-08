using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aviao : MonoBehaviour
{
	Rigidbody2D fisica;
	[SerializeField] private float forca = 6f;
	private Vector3 posicaoInicial;
	private Diretor diretor;

	void Awake()
	{
		this.posicaoInicial = this.transform.position;
    	this.fisica = this.GetComponent<Rigidbody2D>();
	}	 

	private void Start()
	{
		this.diretor = GameObject.FindObjectOfType<Diretor>();
		print(this.diretor);
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

	private void OnCollisionEnter2D(Collision2D colisao){
		this.fisica.simulated = false;
		print(this.diretor);
		this.diretor.FinalizarJogo();
	}
}
