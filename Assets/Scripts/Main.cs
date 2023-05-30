using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    PackMen pacman;
    // Start is called before the first frame update
    void Start()
    {
       pacman = new PackMen();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            ComandoIzquierda c = new ComandoIzquierda();
            c.Ejecutar(pacman);

           
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            ComandoDerecha c = new ComandoDerecha();
            c.Ejecutar(pacman);

 
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            ComandoArriba c = new ComandoArriba();
            c.Ejecutar(pacman);


        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            ComandoAbajo c = new ComandoAbajo();
            c.Ejecutar(pacman);


        }
        Debug.Log("X:" + pacman._posX + " Y:" + pacman._posY);
    }
}
