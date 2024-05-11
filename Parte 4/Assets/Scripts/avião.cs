using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aviao : MonoBehaviour
{
	Rigidbody2D fisica;
	[SerializeField] private float forca = 6f;
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
		this.fisica.velocity = Vector2.zero;
    	this.fisica.AddForce(Vector2.up * this.forca, ForceMode2D.Impulse);
	}
}
