using System.Collections;


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
        UnityEngine.Debug.Log("X:" + _posX + " Y:" + _posY);
    }
}