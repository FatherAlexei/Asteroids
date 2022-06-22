using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainModifier
{
    PlayerModifier mod = new PlayerModifier();
    public void AddSpeedModifier(PlayerController player)
    {
        var speedBoost = new SpeedModifier(10f);
        mod.Add(player, speedBoost);
    }
    public void AddAttackModifier(PlayerController player)
    {
        var attackBoost = new AttackModifier(10f);
        mod.Add(player, attackBoost);
    }
}
