using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ork
{
    //private string _name;
    //protected int Health; //protected доступ к приватным полям
    //protected int Damage;

    public Ork(string name, int health, int damage)
    {
        Name = name;
        Health = health;
        Damage = damage;
    }

    public string Name { get; }
    public int Health { get; protected set; } //protected доступ к приватным полям
    public int Damage { get; protected set; }

    public void TakeDamage(int damage)
    {
        if (damage < 0)
        {
            Debug.LogError("damage < 0");
            return;
        }

        Health -= damage;

        if (Health <= 0)
        {
            Health = 0;
            Debug.Log($"О нет, я, {Name}, умер!");
        }
    }
}
