using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastCabeza : MonoBehaviour {

    Ray ray1;
    Ray ray2;
    public Transform ojoDerecho;
    public Transform ojoIzquierdo;

    void Start () {
		
	}
	
	
	void Update () {
        ray1 = new Ray(ojoDerecho.transform.position, ojoDerecho.transform.right);
        ray2 = new Ray(ojoIzquierdo.transform.position, ojoIzquierdo.transform.right);
        
        if (Input.GetMouseButton(0))
        {
            Debug.DrawRay(ray1.origin, ray1.direction * 100, Color.red);
            Debug.DrawRay(ray2.origin, ray2.direction * 100, Color.red);
            RaycastHit hit;
            if (Physics.Raycast(ray1, out hit, 100,LayerMask.GetMask("Diana")) && Physics.Raycast(ray2, out hit, 100, LayerMask.GetMask("Diana")))
            {
                GameObject g = hit.collider.gameObject;
                Destroy(g);

            }
        }
      
       
	}
}
