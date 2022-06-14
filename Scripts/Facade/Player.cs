using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    static PlayerController playerController;
    static public void CreatePlayer(float speed, float rotation)
    {
        playerController = new PlayerController();
        playerController.speed = speed;
        playerController.rotationSpeed = rotation;
    }
}
