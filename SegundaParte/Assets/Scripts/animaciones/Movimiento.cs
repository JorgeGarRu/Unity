using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour {

    Animator animator;
    public bool saludar;
    public float inputX;
    public float rotacion;
    public float velocidad = 20f;
    public float velocidadRot = 1f;

    //public Transform ojoDerecho;
    //public Transform ojoIzquierdo;
    public Transform PivoteCabeza;
    //public float rotacionOjos;
    //public float velocidadRotacionOjos = 1f;
    public float rotacionCabeza;
    public float velocidadRotacionCabeza = 1f;



    void Start () {
        animator = GetComponentInChildren<Animator>();
        
	}


    void Update()
    {

        //SALUDAR
        if (inputX == 0)
        {
            if (Input.GetKey(KeyCode.Q))
            {
                animator.SetBool("Saludar", true);
                saludar = true;


            }
            else
            {
                animator.SetBool("Saludar", false);
                saludar = false;
            }
            
        } else
        {
            animator.SetBool("Saludar", false);
            saludar = false;
        }

        //ROTACION OJOS 

        //rotacionOjos = Input.GetAxis("Mouse Y") * velocidadRotacionOjos;
        //Vector3 movimientoRotacionOjos = new Vector3(0, 0,rotacionOjos);
        rotacionCabeza = Input.GetAxis("Mouse Y") * velocidadRotacionCabeza;
        Vector3 movimientoRotacionCabeza = new Vector3(0, 0, rotacionCabeza);

        //ojoDerecho.transform.Rotate(movimientoRotacionOjos);
        //ojoIzquierdo.transform.Rotate(movimientoRotacionOjos);
        PivoteCabeza.transform.Rotate(movimientoRotacionCabeza);
        //ANDAR
        if (!saludar)
        {
            inputX = Input.GetAxis("Vertical") * velocidad;
            rotacion = Input.GetAxis("Horizontal") * velocidadRot;
            Vector3 movimiento = new Vector3(0, 0, inputX);
            Vector3 movimientoRotacion = new Vector3(0, rotacion, 0);


            transform.Translate(movimiento);
            transform.Rotate(movimientoRotacion);
        }
            

        if(inputX != 0)
        {
            animator.SetBool("Andando", true);

            
        }
            
         else
        {
            animator.SetBool("Andando", false);
        }
    }

   
	}

