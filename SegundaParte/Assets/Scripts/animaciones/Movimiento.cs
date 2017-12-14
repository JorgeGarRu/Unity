using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour {

    Animator animator;
    public bool saludar;
    public float inputX;
    public float velocidad = 20f;

	void Start () {
        animator = GetComponent<Animator>();
        
	}


    void Update()
    {

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
        }





        //ANDAR
        if (!saludar)
        {
            inputX = Input.GetAxis("Vertical") * velocidad;
            Vector3 movimiento = new Vector3(inputX, 0, 0);


            transform.Translate(movimiento);
        }
            
        
       
            

        if(inputX != 0)
        {
            animator.SetFloat("Andar", 1);

            
        }
            
         else
        {
            animator.SetFloat("Andar", 0);
        }
    }

   
	}

