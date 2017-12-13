using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CRotation : MonoBehaviour
{

    private string turnInputAxis = "Mouse X";
    

    public float rotationRate = 360;
    private CharacterController controller;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        float turnAxis = Input.GetAxis(turnInputAxis);
      

       transform.Rotate(Vector3.up * rotationRate * turnAxis * Time.deltaTime);
        


    }
}
