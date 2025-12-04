using UnityEngine;

public class OrkMage : Ork
{
    public OrkMage(string name, int health, int damage) : base(name, health, damage)
    {

    }

    public void CastSpell()
    {
        Debug.Log("Я использую способность");
    }
}
