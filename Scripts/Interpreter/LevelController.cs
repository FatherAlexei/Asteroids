using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelController : MonoBehaviour
{
    private int lvl = 1;
    public float asteroidSpeed = 0f;
    public GameObject asteroid;
    public Transform[] spawnPoints;
    public Transform center;
    public Text scoreUI;
    public int score = 0;
    void Start()
    {
        StartCoroutine(CreateAsteroids());
    }
    //Interpreter
    private void Update()
    {
        if(score >= 1000000)
            scoreUI.text = "Score: " + MyList.score / 1000000 + "M";
        else if(score>=1000)
         scoreUI.text = "Score: " + MyList.score/1000 + "K";
        
        
    }
    IEnumerator CreateAsteroids()
    {
        for (int i = 0; i < lvl * 2; i++)
        {
            GameObject bufAsteroid = Instantiate(asteroid, spawnPoints[Random.Range(0, spawnPoints.Length)].position, Quaternion.identity);
            MyList.asteroids.Add(bufAsteroid);
            yield return new WaitForSeconds(5);
        }
    }

}
