using System.Collections;


class Fantasma : Personaje, IPersonajeControlable
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
        UnityEngine.Debug.Log("X:" + _posX + " Y:" + _posY);
    }

    public Fantasma(int x, int y)
    {
        _posX = x;
        _posY = y;
    }

}