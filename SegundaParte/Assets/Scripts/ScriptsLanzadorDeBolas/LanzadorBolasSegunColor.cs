using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class LanzadorBolasSegunColor : MonoBehaviour
{

    public GameObject bola;
    public Transform camara;

    public Vector3 direccion;
    public float fuerzaLanzamiento;
    Renderer rend;
    Color[] colores = new Color[] { Color.red, Color.blue, Color.green, Color.yellow };

    //metodos publicos
    public void LanzarBolaRoja()
    {
        GameObject bola1 = (GameObject)Instantiate(bola, camara.transform.position, camara.transform.rotation);//"Quaternion.identity" es la rotacion por defecto

        ColorBola(bola1, Color.red);

        LanzarBola(bola1);


    }

    public void LanzarBolaAzul()
    {
        GameObject bola1 = (GameObject)Instantiate(bola, camara.transform.position, camara.transform.rotation);//"Quaternion.identity" es la rotacion por defecto

        ColorBola(bola1, Color.blue);

        LanzarBola(bola1);


    }

    public void LanzarBolaVerde()
    {
        GameObject bola1 = (GameObject)Instantiate(bola, camara.transform.position, camara.transform.rotation);//"Quaternion.identity" es la rotacion por defecto

        ColorBola(bola1, Color.green);
        
        LanzarBola(bola1);

    }

    public void LanzarBolaAmarillo()
    {
        GameObject bola1 = (GameObject)Instantiate(bola, camara.transform.position, camara.transform.rotation);//"Quaternion.identity" es la rotacion por defecto

        ColorBola(bola1, Color.yellow);

        LanzarBola(bola1);


    }

    public void LanzarBolaRandom()
    {
        GameObject bola1 = (GameObject)Instantiate(bola, camara.transform.position, camara.transform.rotation);//"Quaternion.identity" es la rotacion por defecto

        ColorBola(bola1, colores[Random.Range(0, colores.Length)]);

        LanzarBola(bola1);


    }
   

    //metodos privados
   
    void LanzarBola(GameObject bola) //metodo para añadir fuerza a las bolas.
    {
        Rigidbody myRigidbody = bola.GetComponent<Rigidbody>();
        direccion = new Vector3(-5, 0, 0) - camara.transform.position;
        direccion = direccion.normalized;
        Vector3 fuerza = direccion * fuerzaLanzamiento;
        myRigidbody.AddForce(fuerza, ForceMode.Impulse);
    }
    void ColorBola(GameObject bola, Color color)//metodo para cambiar el color de las bolas instanciadas
    {
       
        rend = bola.GetComponent<Renderer>();
        rend.material.color = color;
    } 
}
    
        

