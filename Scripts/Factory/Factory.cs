using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Factory
{
    private Dictionary<string, Func<int, MobModel>> mobFactory;

    public void Init(ArraysMobs descriptions)
    {
        mobFactory = new Dictionary<string, Func<int, MobModel>>()
        {
            {"mele", (level) => new MobModel(descriptions.ListMele[level])},
            {"Mage", (level) => new MobModel(descriptions.ListMage[level])}
        };

    }

    public MobModel CreateMobModel(string nameMob, int level)
    {
        return mobFactory[nameMob](level);
    }
}
