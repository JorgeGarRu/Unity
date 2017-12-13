using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour {


    public Rigidbody myRigidbody; //rigidboody de la bala de la nave
    Vector3 direccion;
    public float fuerzaLanzamiento;
    public bool disparar; // con esta variable controlaremos que a la bala solo se aplique la fuerza cuando lo pongamos a true.
    

    void Start()
    {

        
    }

    // Update is called once per frame
    void FixedUpdate()
    {


        direccion = transform.up;
        Vector3 fuerza = direccion * fuerzaLanzamiento;


        if (!disparar)
        {
            myRigidbody.AddForce(fuerza); //añadimos una fuerza a la bala de la nave

            disparar = true;
            myRigidbody.velocity = Vector3.zero; //ponemos la velocidad a cero para cuando volvamos a disparar, parta desde cero.

        }

    }
}

