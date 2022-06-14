using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandartMove : MonoBehaviour, IMove
{
    private float speed = 10;
    public void Move()
    {
        if(TryGetComponent(out Rigidbody2D rb))
            rb.AddForce(gameObject.transform.up * speed);
    }
}
