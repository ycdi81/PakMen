using System.Collections;

interface ICommand
{
    public void Ejecutar();
}


class ComandoArriba : ICommand
{
    IPersonajeControlable _personaje;
    public ComandoArriba(IPersonajeControlable personaje) => _personaje = personaje;
    public void Ejecutar() => _personaje.Mover(new UnityEngine.Vector2(0, 1));

}

class ComandoAbajo : ICommand
{
    IPersonajeControlable _personaje;
    public ComandoAbajo(IPersonajeControlable personaje) => _personaje = personaje;
    public void Ejecutar() => _personaje.Mover(new UnityEngine.Vector2(0, -1));

}

class ComandoDerecha : ICommand
{
    IPersonajeControlable _personaje;
    public ComandoDerecha(IPersonajeControlable personaje) => _personaje = personaje;
    public void Ejecutar() => _personaje.Mover(new UnityEngine.Vector2(1, 0));

}

class ComandoIzquierda : ICommand
{
    IPersonajeControlable _personaje;
    public ComandoIzquierda(IPersonajeControlable personaje) => _personaje = personaje;
    public void Ejecutar() => _personaje.Mover(new UnityEngine.Vector2(-1, 0));

    //lets begin 23423
}