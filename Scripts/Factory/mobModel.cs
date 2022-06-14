using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobModel
{
    private ModDesc _description;
    private float _currentHealth;

    public ModDesc Description => _description;

    public MobModel(ModDesc description)
    {
        _description = description;
        _currentHealth = _description.Health;
    }

}