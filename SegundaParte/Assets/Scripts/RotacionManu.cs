using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionManu : MonoBehaviour {
    public float speed = 1f;
    public Transform head;
    public Transform body;

	
	
	
	void Update () {
        float inputV = Input.GetAxis("Mouse Y");
        float inputH = Input.GetAxis("Mouse X");

        float anglesV = inputV * speed;
        float anglesH = inputH * speed;

        head.Rotate(anglesV, 0, 0);
        body.Rotate(0, anglesH, 0);
	}
}
