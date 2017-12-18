using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticulasController : MonoBehaviour {

    public ParticleSystem particulas;
	
	void Start () {
        particulas = GetComponent<ParticleSystem>();
        //para poder cambiar algun valor de un modulo de las particulas...

        ParticleSystem.EmissionModule emision = particulas.emission;
        emision.rateOverTime = 10f;
	}
	
	
	void Update () {
        if (Input.GetKeyDown(KeyCode.A))
        {
            particulas.Play();
        } else if (Input.GetKeyDown(KeyCode.B))
        {
            particulas.Stop();
            
            
        }
	}
}
