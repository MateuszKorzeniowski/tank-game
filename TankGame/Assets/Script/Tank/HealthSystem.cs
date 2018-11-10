using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem{


    private int health;
    private int healthMax;

    public HealthSystem(int healthMax)
    {
        this.healthMax = healthMax;
        health = healthMax;
    }

    public int GetHealth()
    {
        return health;
    }
    
    public void SetHealth(int health)
    {
        this.health = health;
    }

    public void Demage(int demageAmount)
    {
        health -= demageAmount;
        if(health < 0 )
        {
            //destruction
            health = 0;
        }
    }

    public void Heal(int healAmount)
    {
        health += healAmount;
        if (health > healthMax) health = healthMax;
    }

    public float GetHealthProcent()
    {
        return (float)health / healthMax;
    }
}
