using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShip : MonoBehaviour
{
    private readonly List<Ability> abilities;

    public EnemyShip(List<Ability> abilities)
    {
        this.abilities = abilities;
    }

    public Ability this[int index] => abilities[index];

    public IEnumerable<Ability> GetAbility()
    {
        while(true)
        {
            yield return abilities[Random.Range(0, abilities.Count)];
        }
    }

    public IEnumerator GetEnumerator()
    {
        for(int i = 0; i < abilities.Count; i++)
        {
            yield return abilities[i];
        }
    }
}
