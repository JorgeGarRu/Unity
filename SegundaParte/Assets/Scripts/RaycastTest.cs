using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastTest : MonoBehaviour {
    Ray ray;
    Vector3 pos;
    Vector3 direccion;
    public float longitud;
    public Transform spawn;
    public GameObject balaPrefab;

    void Start () {
    
	}
	
	
	void Update () {



        if (Input.GetMouseButtonDown(0)) //si pulso el boton izquierdo del mouse...
        {
            //creo el Raycast
            pos = spawn.transform.position; //para que salga de la posicion del arma
            direccion = spawn.transform.up; //direccion del arma

            ray = new Ray(pos, direccion);
            Debug.DrawRay(ray.origin, ray.direction * longitud, Color.red);//dibujamos el raycast dandole el origen, la direccion multiplicada por la longitud y el color.
            RaycastHit hit; //aqui es donde se guarda la informacion del elemento con el que choca el ray si es True.
            if (Physics.Raycast(ray, out hit, 100,LayerMask.GetMask("suelo")))//out hit, se utiliza como un segundo return que devuelve el hit
            {

                Vector3 pointHit = hit.point; //cogemos el punto donde choca el raycast
                GameObject.Instantiate(balaPrefab, pointHit, Quaternion.identity);//"Quaternion.identity" es la rotacion por defecto
             
            }
        }
	}
}
