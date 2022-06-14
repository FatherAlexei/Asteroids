using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityList : MonoBehaviour
{
    void Start()
    {
        var ability = new List<Ability>
        {
            new Ability("Explosion", 2),
            new Ability("Laser", 1),
            new Ability("Gas", 1)
        };

        EnemyShip enemy = new EnemyShip(ability);
    }


}
