public class Ninja:Human
{
    public Ninja(string ninjaName):base(ninjaName)
    {
        dexterity = 175;
    }

    public void Steal(object target)
    {
        Human enemy = target as Human;
        if (enemy != null)
        {
            Attack(enemy);
            health += 10;
        }
    }

    public void get_away()
    {
        health -= 15;
    }
}