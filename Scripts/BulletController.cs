using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponentInParent<PlayerController>())
        {
            collision.GetComponent<PlayerDamage>().GetDamage();
            Destroy(gameObject, 0f);
        }
        if (collision.GetComponent<AsteroidController>())
        {
            MyList.asteroids.Remove(collision.GetComponent<GameObject>());
            MyList.score += 50;
            collision.GetComponent<AsteroidController>().GetDamage();
            Destroy(gameObject, 0f);
        }
    }
}
