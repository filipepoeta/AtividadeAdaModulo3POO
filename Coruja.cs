using Animais.ClassesBase;

namespace Animais;

public class Coruja : Ave, IVoar, IOviparo
{
    public int AltitudeMaimaEmMetros { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public double VelocidadeDoVoo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public void Botar()
    {
    }

    public void Chocar()
    {
    }
}