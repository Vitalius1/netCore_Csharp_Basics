using System;
public class Wizard:Human
{
    public Wizard(string wizName):base(wizName)
    {
        health = 50;
        intelligence = 25;
    }
    
    public void Heal()
    {
        health += 10 * intelligence;
    }

    public void Fireball(object target)
    {
        Human enemy = target as Human;
        if(enemy != null)
        {
        Random rand = new Random();
        enemy.health -= rand.Next(20, 51);
        }
    }
}