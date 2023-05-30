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
            pacman.mover(new ComandoIzquierda());
        }
    }
}
