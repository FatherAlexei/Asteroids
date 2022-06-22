using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ArraysMobs", menuName = "ArraysMobs", order = 51)]
public class ArraysMobs : ScriptableObject
{
    [SerializeField] private List<ModDesc> listMage;
    [SerializeField] private List<ModDesc> listMele;

    public List<ModDesc> ListMage => listMage;
    public List<ModDesc> ListMele => listMele;
}
