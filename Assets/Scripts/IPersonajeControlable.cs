using System.Collections;
using System.Collections.Generic;


interface IPersonajeControlable
{
    public void Mover(UnityEngine.Vector2 mov);
    public void Aparecer(int x, int y);
    public void Morir();
    public void Herir(int fuerza);


}