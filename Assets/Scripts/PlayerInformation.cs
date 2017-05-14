using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInformation : MonoBehaviour
{
    [SerializeField]
    private int attack;

    [SerializeField]
    private int defence;

    public int maxHealth;
    public int team;
    private int currentHealth;

    public void getHit(int damage)
    {
        currentHealth = currentHealth - damage;
        if (currentHealth < 0)
        {
            currentHealth = 0;
        }
    }


    public int getAttack() { 
        return attack;
    }

    public void setAttack(int newAttack)
    {
        if (newAttack < 0) {
            this.attack = 0;
        }
        else
        {
            this.attack = newAttack;
        }
    }

    public int getDefence()
    {
        return defence;
    }

    public void setDefence(int newDefence)
    {
        defence = newDefence;
    }

    public int getCurrentHealth()
    {
        return currentHealth;
    }

    public void setCurrentHealth(int health)
    {
       if (health < 0)
        {
            currentHealth = 0;
        }
        else
        {
            currentHealth = health;
        }
    }
}
