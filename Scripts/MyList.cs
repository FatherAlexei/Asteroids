using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyList : MonoBehaviour, IDisposable
{
    public static int score = 0;
    public static List<GameObject> asteroids = new List<GameObject>();
    public void Dispose()
    {
        asteroids.Clear();
    }
}
 