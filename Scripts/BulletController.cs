using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponentInParent<PlayerController>())
        {
            collision.GetComponent<PlayerDamage>().GetDamage();
            Destroy(gameObject, 0f);
        }
    }
}
