using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedModifier
{
    public float speed;
    public SpeedModifier(float speed)
    {
        this.speed += speed;
    }
}
