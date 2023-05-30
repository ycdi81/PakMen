using System.Collections;
using System.Collections.Generic;


interface IPersonajeControlable 
{
    public void Mover(ICommand command);
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

    public void Mover(ICommand command)
    {
        command.Ejecutar();
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

    public void Mover(ICommand command)
    {
        throw new System.NotImplementedException();
    }

    public Fantasma(int x, int y)
    {
        _posX = x;
        _posY = y;
    }

}

interface ICommand
{
    public void Ejecutar();
}


class ComandoArriba : ICommand
{
    void ICommand.Ejecutar() => UnityEngine.Debug.Log("Arriba");

}

class ComandoAbajo : ICommand
{
    void ICommand.Ejecutar() => UnityEngine.Debug.Log("Abajo");

}

class ComandoDerecha : ICommand
{
    void ICommand.Ejecutar() => UnityEngine.Debug.Log("Derecha");

}

class ComandoIzquierda : ICommand
{
    void ICommand.Ejecutar() => UnityEngine.Debug.Log("Izquierda");
   

}



