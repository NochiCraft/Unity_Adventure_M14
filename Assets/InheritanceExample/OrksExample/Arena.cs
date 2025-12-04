using UnityEngine;

public class Arena : MonoBehaviour
{
    void Start()
    {
        //Ork ork = new Ork("Базовый Орк", 100, 20);

        OrkPaladin orkPaladin = new OrkPaladin("Орк-паладин", 35, 3);
        OrkMage orkMage = new OrkMage("Орк-маг", 20, 5);

        ProcessBattle(orkMage, orkPaladin);

        DetermineWinner(orkMage, orkPaladin);
    }

    private void ProcessBattle(OrkMage orkMage, OrkPaladin orkPaladin)
    {
        while(orkMage.Health > 0 && orkPaladin.Health > 0)
        {
            orkMage.CastSpell();
            orkPaladin.TakeDamage(orkMage.Damage);

            orkPaladin.Heal();
            orkMage.TakeDamage(orkPaladin.Damage);

            Debug.Log($"{orkPaladin.Name} - {orkPaladin.Health}");
            Debug.Log($"{orkMage.Name} - {orkMage.Health}");
        }
    }

    private void DetermineWinner(OrkMage orkMage, OrkPaladin orkPaladin)
    {
        if (orkMage.Health <= 0 && orkPaladin.Health <= 0)
            Debug.Log("Ничья!");
        else if (orkMage.Health > 0)
            Debug.Log($"Победил {orkMage.Name}");
        else
            Debug.Log($"Победил {orkPaladin.Name}");
    }
}
