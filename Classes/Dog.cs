public class Dog:Animal{
    public Dog(double weight, string type, string diet = "carnivore", int legs = 4)
    {
        NumLegs = legs;
        this.weight = weight;
        this.type = type;
        this.diet = diet;
    }
    public new void Speak(){
        System.Console.WriteLine("Wooof");
    }
}