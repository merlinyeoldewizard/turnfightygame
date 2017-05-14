using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combat {

    PlayerInformation attacking;
    PlayerInformation defending;
    

    public Combat(PlayerInformation attacker, PlayerInformation defender)
    {
        setAttacking(attacker);
        Defending = defender;
    }

    public void Attack()
    {
        int damage = attacking.getAttack() - defending.getDefence();
        if (damage < 0)
        {
            damage = 0;
        }
        defending.getHit(damage);
    }


    public PlayerInformation getAttacking()
    {
        return attacking;
    }

    public void setAttacking(PlayerInformation attacking)
    {
        this.attacking = attacking;
    }

    public PlayerInformation Defending {
        get { return defending; }
        set { defending = value; }
    }
}