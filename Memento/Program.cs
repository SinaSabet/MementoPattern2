
ComeBackToFirstPosition Position = new ComeBackToFirstPosition();


Position.Position = "Step1";
Ceretaker ceretaker=new Ceretaker();
ceretaker.Memento=Position.AddMemento();
Position.Position = "Step2";
Position.Position = "Step3";

Position.Restart(ceretaker.Memento);
Console.ReadKey();
public class ComeBackToFirstPosition
{
    string position;
    public string Position { get { return position; } set { position = value; Console.WriteLine($"the position is {Position}"); } }
    public Memento AddMemento()
    {
        return (new Memento(Position));
    }
   
    public void Restart(Memento memento)
    {
        Console.WriteLine("Position Restart and Come Back ");
        Position = memento.Position;
    }
}

public class Memento
{
   private string position;
    public Memento(string position)
    {
        this.position = position;   
    }

    public string Position { get { return position; }  }

}


public class Ceretaker
{
    Memento memento;
    public Memento Memento { get { return memento; } set { memento = value; } }
}