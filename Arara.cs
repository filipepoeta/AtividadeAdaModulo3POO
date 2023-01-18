using Animais.ClassesBase;

namespace Animais;

public class Arara : Ave, IOviparo, IVoar
{
    public int AltitudeMaimaEmMetros { get ; set; }
    public double VelocidadeDoVoo { get; set; }

    public void Botar()
    {
    }

    public void Chocar()
    {
    }
}