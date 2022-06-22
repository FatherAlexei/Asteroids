using System.Collections;
using System.Collections.Generic;
using UnityEngine;

internal sealed class Enemy
{
    private IAttack attack;
    private IMove move;

    public Enemy(IAttack attack, IMove move)
    {
        this.attack = attack;
        this.move = move;
    }

    public void fire()
    {
        attack.fire();
    }

    public void Move()
    {
        move.Move();
    }
}
