using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponProxy
{
    private readonly Weapon weapon;
    private readonly bool unlock;
    private readonly Text text;

    public WeaponProxy(Weapon weapon,bool unlock, Text text)
    {
        this.weapon = weapon;
        this.text = text;
        this.unlock = unlock;
    }

    public void fire()
    {
        if(unlock)
        {
            weapon.fire();
        }
        else
        {
            text.text = "Weapon blocked";
        }
    }
}
