using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Marcador : MonoBehaviour {

    public Text texto;
    int puntuacionActual = 0;

    void Start()
    {

        texto = GetComponent<Text>();
        texto.text = puntuacionActual.ToString();
    }


    void Update()
    {

    }

    public void añadirPuntuacion()
    {
        puntuacionActual++;
        texto.text = puntuacionActual.ToString();
    }
}
