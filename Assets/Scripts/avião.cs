using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aviao : MonoBehaviour
{
	Rigidbody2D fisica;

	void Awake()
	{
    	this.fisica = this.GetComponent<Rigidbody2D>();
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
    	this.fisica.AddForce(Vector2.up * 5, ForceMode2D.Impulse);
	}

	private void OnCollisionenter2D(Collision colisao){
		this.fisica.simulated = false;
	}
}

