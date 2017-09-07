public class Animal{
    public int NumLegs;
    public string type;
    public double weight;
    public string diet;
    public double distance = 0;

    public void Speak(){
        System.Console.WriteLine("I'm an animal...");
    }
    public double Move(double feet){
        distance += feet;
        return feet;
    }
}