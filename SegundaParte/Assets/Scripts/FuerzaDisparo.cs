using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuerzaDisparo : MonoBehaviour {
    public GameObject bala;
    public Transform spawn;
	
	void Start () {
		
	}
	
	
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bala, spawn.transform.position, spawn.rotation);
            Disparo disparo = bala.GetComponent<Disparo>(); //accedemos al script DisparoNave
            disparo.disparar = false;//y ponemos la variable "disparar" en false para que la bala salga con la fuerza necesaria descrita
        }
    }
}
