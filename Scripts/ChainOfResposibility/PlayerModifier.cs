using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerModifier
{
    public void Add(PlayerController player, AttackModifier attack)
    {
        player.damage += attack.damage;
    }
    public void Remove(PlayerController player, AttackModifier attack)
    {
        player.damage -= attack.damage;
    }
    public void Add(PlayerController player, SpeedModifier speed)
    {
        player.speed += speed.speed;
    }
    public void Remove(PlayerController player, SpeedModifier speed)
    {
        player.speed -= speed.speed;
    }
}
