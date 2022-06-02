using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prototype : MonoBehaviour
{
    private float force = 10;
    public Prototype Clone(GameObject gameObject, Transform pos)
    {
        Prototype newObject = default;
        newObject = new GameObject(gameObject.name).AddComponent<Prototype>();
        if(gameObject.TryGetComponent<Rigidbody2D>(out var rigidbody2D))
        {
            var rigidbodyNew = newObject.gameObject.AddComponent<Rigidbody2D>();
            rigidbodyNew.velocity = rigidbody2D.velocity;
        }
        if (gameObject.TryGetComponent<SpriteRenderer>(out var spriteRenderer))
        {
            var spriteRendererNew = newObject.gameObject.AddComponent<SpriteRenderer>();
            spriteRendererNew.sprite = spriteRenderer.sprite;
        }
        if (gameObject.TryGetComponent<CircleCollider2D>(out var circleCollider2D))
        {
            var circleColliderNew = newObject.gameObject.AddComponent<CircleCollider2D>();
            circleColliderNew.radius = circleCollider2D.radius;
        }
        newObject.transform.position = new Vector3(pos.position.x, pos.position.y, pos.position.z);
        return newObject;
    }
}
