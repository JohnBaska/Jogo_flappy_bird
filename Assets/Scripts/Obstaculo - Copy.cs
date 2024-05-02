using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    // Start is called before the first frame update
    void Update()
    {
    	print("go");
        this.transform.Translate(Vector3.left*0.1f);
    }


}
