using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    PackMen pacman;
    Fantasma fantasma;
    IPersonajeControlable _personajeActivo;

    void Start()
    {
       _personajeActivo = pacman = new PackMen();
        fantasma = new Fantasma(100, 100);
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            ComandoIzquierda c = new ComandoIzquierda(_personajeActivo);
            c.Ejecutar();

           
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            ComandoDerecha c = new ComandoDerecha(_personajeActivo);
            c.Ejecutar();

 
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            ComandoArriba c = new ComandoArriba(_personajeActivo);
            c.Ejecutar();


        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            ComandoAbajo c = new ComandoAbajo(_personajeActivo);
            c.Ejecutar();


        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (_personajeActivo == fantasma)
                _personajeActivo = pacman;
            else
                _personajeActivo = fantasma;
        }

    }
}
