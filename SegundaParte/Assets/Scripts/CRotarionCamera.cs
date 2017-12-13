using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CRotarionCamera : MonoBehaviour {
    private string turnInputAxis1 = "CamaraVertical";
    public float rotationRate = 360;
    

    void Start () {

        
    }
	
	
	void Update () {
        float turnAxis1 = Input.GetAxis(turnInputAxis1);
        transform.Rotate(turnAxis1*-rotationRate*Time.deltaTime,0,0);

    }
}
