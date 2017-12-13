using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SeguirBolas : MonoBehaviour {

    NavMeshAgent agent;

	void Start () {
        agent = GetComponent<NavMeshAgent>();
	}
	
	
	void Update () {

        Collider[] bolas = Physics.OverlapSphere(transform.position, 50, LayerMask.GetMask("bolas")); //Con "OverlapSphere" guardamos todos objetos que haya en un radio de 50 desde la posicion del jugador , por cada frame. Y lo guardamos en un array de Colliders

        if(bolas != null && bolas.Length>0) //si el array no está vacío...
        {
            GameObject bolaMasCercana = DevuelveBolaMasCercana(bolas); //llamando al metodo de abajo, guardamos en una variable la bola mas cercana del array
            agent.SetDestination(bolaMasCercana.transform.position); //y le decimos al jugador que siga a esa bola.
        }
        
	}

   private GameObject DevuelveBolaMasCercana(Collider[] bolas) //metodo para devolver la bola mas cercana al jugador
    {
        GameObject bola = null;
        float minimaDistancia = float.MaxValue; //guardamos en minimaDistancia un valor maximo para despues ir comparando
        foreach(Collider col in bolas) //recorremos el array de Colliders
        {
            GameObject b = col.gameObject; //en una variable "GameObject", guardamos la bola actual.
            float distancia = Vector3.Distance(transform.position, b.transform.position); //y giuardamos la distancia entre el jugador y la bola actual
            if(distancia < minimaDistancia) //si esa distancia es menor que la distanciaMinima que tenemos guardada...(en el primer caso, siempre lo será, ya que arriba le hemos dicho que coja el valor maximo
            {
                bola = b; //guardamos en el GameObject "bola", dicha bola
                minimaDistancia = distancia; //y sobreescribimos la distanciaMinima para seguir comparando.
            }

        }
        return bola;
    }

    private void OnTriggerEnter(Collider other) // solo afectara el trigguer cuando uno de los dos elementos que choquen, tenga un rigidbody...
    {
        Destroy(other.gameObject); //destruimos las bolas cuando el jugador llegue a ellas.
    }
}
