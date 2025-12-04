using UnityEngine;

public class OrkPaladin : Ork
{
    //public OrkPaladin() : base("Орк", 100, 20)
    //{

    //}

    public OrkPaladin(string name, int health, int damage) : base(name, health, damage)
    {

    }
        
    public void Heal()
    {
        Debug.Log("Я использую лечение");
    }
}
