using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionesBala : MonoBehaviour {

	
	void Start () {
		
	}
	
	
	void Update () {
		
        
	}

    private void OnCollisionEnter(Collision collision)
    {
       GameObject.Destroy(gameObject);
        GameObject obj = collision.gameObject;
        GameObject.Destroy(obj);

    }
}
