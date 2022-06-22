using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBackState : State
{
    public override void Handle(PlayerController playerController)
    {
        Rigidbody2D rb = playerController.GetComponent<Rigidbody2D>();
        rb.AddForce(playerController.transform.up * -playerController.speed);
    }
}
