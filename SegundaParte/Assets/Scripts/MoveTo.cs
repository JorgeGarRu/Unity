using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI; //para usar la navegacion

public class MoveTo : MonoBehaviour {
    public Transform target; //transform de la esfera 
   NavMeshAgent agent; 

	void Start () {
        agent = GetComponent<NavMeshAgent>(); //que lo pille automaticamente
        //agent.SetDestination(target.position); //al comenzar el juego, hacemos que nuestro jugador vaya hacia la posicion de la esfera.
	}
	
	
	void Update () {
        agent.SetDestination(target.position); //para que si movemos la esfera, el jugador siga a la esfera
    }
}
