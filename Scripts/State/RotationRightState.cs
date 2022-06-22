using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationRightState : State
{
    public override void Handle(PlayerController playerController)
    {
        Rigidbody2D rb = playerController.GetComponent<Rigidbody2D>();
        rb.AddTorque(-1 * playerController.rotationSpeed);
    }
}
