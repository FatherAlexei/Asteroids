using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperMove : MonoBehaviour
{
    private float speed = 10;
    private float boost = 100;
    public void Move()
    {
        if (TryGetComponent(out Rigidbody2D rb))
            rb.AddForce(gameObject.transform.up * speed * boost);
    }
}
