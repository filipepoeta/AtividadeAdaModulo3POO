using Animais.ClassesBase;

namespace Animais;

public class Pinguim : Ave, IOviparo, IAquatico
{
    public bool ViveEmTerra { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public bool Mergulho { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public bool AguaDoce { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public void Botar()
    {
    }

    public void Chocar()
    {
    }
}