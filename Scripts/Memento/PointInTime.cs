using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointInTime
{
    public Vector2 position;
    public Quaternion rotation;
    public Vector2 velocity;
    public float angularVelocity;

    public PointInTime(Vector2 position, Quaternion rotation, Vector2 velocity, float angularVelocity)
    {
        this.position = position;
        this.rotation = rotation;
        this.velocity = velocity;
        this.angularVelocity = angularVelocity;
    }                  
}
