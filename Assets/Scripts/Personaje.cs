using System.Collections;
using System.Collections.Generic;


interface IPersonajeControlable 
{
    public void Mover(UnityEngine.Vector2 mov);
    public void Aparecer(int x, int y);
    public void Morir();

    public void Herir(int fuerza);


}

class Personaje
{
    public int _posX, _posY;


}

class PackMen : Personaje, IPersonajeControlable
{
    
    public void Aparecer(int x, int y)
    {
        throw new System.NotImplementedException();
    }

    public void Herir(int fuerza)
    {
        throw new System.NotImplementedException();
    }

    public void Morir()
    {
        throw new System.NotImplementedException();
    }

    public void Mover(UnityEngine.Vector2 mov)
    {
        _posX += (int)mov.x;
        _posY += (int)mov.y;
    }
}

class Fantasma : Personaje,IPersonajeControlable
{
    void IPersonajeControlable.Aparecer(int x, int y)
    {
        throw new System.NotImplementedException();
    }

    void IPersonajeControlable.Herir(int fuerza)
    {
        throw new System.NotImplementedException();
    }

    void IPersonajeControlable.Morir()
    {
        throw new System.NotImplementedException();
    }

    public void Mover(UnityEngine.Vector2 mov)
    {
        _posX += (int)mov.x;
        _posY += (int)mov.y;
    }

    public Fantasma(int x, int y)
    {
        _posX = x;
        _posY = y;
    }

}

interface ICommand
{
    public void Ejecutar(IPersonajeControlable pers);
}


class ComandoArriba : ICommand
{
    public void Ejecutar(IPersonajeControlable pers) => pers.Mover(new UnityEngine.Vector2(0,-1));

}

class ComandoAbajo : ICommand
{
    public void Ejecutar(IPersonajeControlable pers) => pers.Mover(new UnityEngine.Vector2(0, 1));

}

class ComandoDerecha : ICommand
{
    public void Ejecutar(IPersonajeControlable pers) => pers.Mover(new UnityEngine.Vector2(1, 0));

}

class ComandoIzquierda : ICommand
{
    public void Ejecutar(IPersonajeControlable pers) => pers.Mover(new UnityEngine.Vector2(-1, 0));

    //lets begin 23423
}



