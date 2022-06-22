using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ability : MonoBehaviour
{
    public string name;
    public int damage;
    
    public Ability(string name, int damage)
    {
        this.name = name;
        this.damage = damage;
    }

    public override string ToString()
    {
        return name; 
    }
}
