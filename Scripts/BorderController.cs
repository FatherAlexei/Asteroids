using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderController : MonoBehaviour
{
    public bool left = false;
    public bool right = false;
    public bool top = false;
    public bool bot = false;
    public Transform anotherWall;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(left == true)
            collision.transform.position = new Vector2(anotherWall.position.x-1, collision.transform.position.y);
        else if (right == true)
            collision.transform.position = new Vector2(anotherWall.position.x + 1, collision.transform.position.y);
        else if (top == true)
            collision.transform.position = new Vector2(collision.transform.position.x, anotherWall.position.y + 1);
        else if (bot == true)
            collision.transform.position = new Vector2(collision.transform.position.x, anotherWall.position.y - 1);
    }
}
