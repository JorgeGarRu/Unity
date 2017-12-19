using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class LolTest : MonoBehaviour {

    Ray ray;
  
    public float longitud;
    
    public GameObject balaPrefab;
    public GameObject jugador;
   public NavMeshAgent agente;
    

    void Start()
    {
       
    }


    void Update()
    {

      

        if (Input.GetMouseButtonDown(0)) //si pulso el boton izquierdo del mouse...
        {


            ray = Camera.main.ScreenPointToRay(Input.mousePosition); //creamos un raycast hasta la posicion donde pinchemos con el raton
            Debug.DrawRay(ray.origin, ray.direction * longitud, Color.red);//dibujamos el raycast dandole el origen, la direccion multiplicada por la longitud y el color.
            RaycastHit hit; //aqui es donde se guarda la informacion del elemento con el que choca el ray si es True.
            if (Physics.Raycast(ray, out hit, 1000, LayerMask.GetMask("suelo")))//out hit, se utiliza como un segundo return que devuelve el hit
            {

                Vector3 pointHit = hit.point; //cogemos el punto donde choca el raycast
                //GameObject.Instantiate(balaPrefab, pointHit, Quaternion.identity);//"Quaternion.identity" es la rotacion por defecto
                //GameObject obj = hit.collider.gameObject;
                //GameObject.Destroy(obj);
                agente.destination = pointHit;
                
            }
        }
    }
}

