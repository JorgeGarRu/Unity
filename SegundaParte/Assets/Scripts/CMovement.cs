using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CMovement : MonoBehaviour {

    private string movInputAxis = "Vertical";
    private string movInputAxis1 = "Horizontal";

    public float moveSpeed = 2;
    public float fuerzaSalto = 2;
    public float gravity = 20f;
    private CharacterController controller;
    private Vector3 moveDirection = Vector3.zero;
    public GameObject bala;
    public Transform spawn;
   
   
    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }
    void Update () {

        //Mover Jugador
        float moveAxis = Input.GetAxis(movInputAxis)*moveSpeed;
        float moveAxis1 = Input.GetAxis(movInputAxis1) * moveSpeed;

        Vector3 movement = new Vector3(moveAxis1, 0, moveAxis);
       
        Vector3 localInput = transform.TransformDirection(movement); //para coger los ejes locales
        controller.SimpleMove(localInput);


        //Saltar
        if (Input.GetButton("Jump")) 
            if (controller.isGrounded) //si el jugador está en el suelo...
            {
                moveDirection.y = fuerzaSalto; //Al eje Y le aplico la fuerza de salto
                

            }


        moveDirection.y -= gravity * Time.deltaTime; //Al eje Y le aplicamos una gravedad para la caida.



        controller.Move(moveDirection * Time.deltaTime);

        //disparar
        //if (Input.GetMouseButtonDown(0))
        //{
        //    Instantiate(bala, spawn.transform.position,spawn.rotation);
        //    Disparo disparo = bala.GetComponent<Disparo>(); //accedemos al script DisparoNave
        //    disparo.disparar = false;//y ponemos la variable "disparar" en false para que la bala salga con la fuerza necesaria descrita
        //}
            
        
        
    }

    


}

