using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Lanzador : MonoBehaviour {

    public GameObject bola;
    
    public float longitud = 500f;
    public Vector3 direccion;
    public float fuerzaLanzamiento;
  




    void Start () {
       
    }
	
	
	void FixedUpdate () {
        if (Input.GetMouseButtonDown(0)) //si pulso el boton izquierdo del mouse...
        {


           Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); //creamos un raycast hasta la posicion donde pinchemos con el raton
            Debug.DrawRay(ray.origin, ray.direction * longitud, Color.red);//dibujamos el raycast dandole el origen, la direccion multiplicada por la longitud y el color.
            RaycastHit hit; //aqui es donde se guarda la informacion del elemento con el que choca el ray si es True.
            if (Physics.Raycast(ray, out hit, 1000))//out hit, se utiliza como un segundo return que devuelve el hit
            {

                Vector3 pointHit = hit.point; //cogemos el punto donde choca el raycast
                GameObject bola1 = (GameObject) Instantiate(bola, transform.position, transform.rotation);//"Quaternion.identity" es la rotacion por defecto
                //target = bola1.transform;
                


                Rigidbody myRigidbody = bola1.GetComponent<Rigidbody>();

                direccion = pointHit-transform.position;
                direccion = direccion.normalized;
                Vector3 fuerza = direccion * fuerzaLanzamiento;
                myRigidbody.AddForce(fuerza,ForceMode.Impulse);

               

            }
            }
        }
    }

