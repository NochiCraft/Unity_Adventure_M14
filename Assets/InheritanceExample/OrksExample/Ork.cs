using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ork
{
    private string _name = "Орк";
    private int _health = 100;
    private int _damage = 20;

    public string Name => _name;
    public int Health => _health;
    public int Damage => _damage;

    //Или можно было полностью через автосвойства
    //public string Name { get; private set; } = "Орк";
    //public int Health { get; private set; } = 100;
    //public int Damage { get; private set; } = 20;

    public void TakeDamage(int damage)
    {
        if (damage < 0)
        {
            Debug.LogError("damage < 0");
            return;
        }

        _health -= damage;

        if (_health <= 0)
        {
            _health = 0;
            Debug.Log($"О нет, я, {_name}, умер!");
        }
    }
}
