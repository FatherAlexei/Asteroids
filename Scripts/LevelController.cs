using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    private int lvl = 1;
    public float asteroidSpeed = 2f;
    public GameObject asteroid;
    public Transform[] spawnPoints;
    public Transform center;
    public Prototype prototype;
    void Start()
    {
        StartCoroutine(CreateAsteroids());
    }

    IEnumerator CreateAsteroids()
    {
        for (int i = 0; i < lvl * 2; i++)
        {
            prototype = new Prototype();
            Prototype bufAsteroid = prototype.Clone(asteroid, spawnPoints[Random.Range(0, spawnPoints.Length)].transform);
            Rigidbody2D asteroidRb = bufAsteroid.GetComponent<Rigidbody2D>();
            Vector2 dir = center.transform.position - transform.position;
            dir = dir.normalized;
            asteroidRb.AddForce(asteroidSpeed * dir);
            yield return new WaitForSeconds(5);
        }
    }
}
