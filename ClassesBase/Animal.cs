namespace Animais.ClassesBase;

public class Animal
{
    public string Nome { get; set; }
    public DateTime DataDeNascimento { get; set; }
    public char Sexo { get; set; }
    public int Idade { get; set; }

    public void Movimentar(){

    }
    public void Comunicar(){

    }
    public bool Carnivoro(){
        return false;
    }

    public void Alimentar(){

    }
    public bool Peconhento(){
        return false;
    }

    
}