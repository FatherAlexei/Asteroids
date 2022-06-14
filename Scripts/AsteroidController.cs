using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidController : MonoBehaviour
{
    public float asteroidSpeed = 1000f;
    void Start()
    {
        Rigidbody2D asteroidRb = gameObject.GetComponent<Rigidbody2D>();
        asteroidRb.AddForce(asteroidSpeed * new Vector2(0f,0f));
    }

    public void GetDamage()
    {
        Destroy(gameObject, 0f);
    }
}
