using UnityEngine;

public sealed class BulletPhysicsBuilder : BulletBuilder
{
    public BulletPhysicsBuilder(GameObject gameObject) : base(gameObject) { }

    public BulletPhysicsBuilder BoxCollider2D()
    {
        GetOrAddComponent<BoxCollider2D>();
        return this;
    }

    public BulletPhysicsBuilder Rigidbody2D(float mass)
    {
        var component = GetOrAddComponent<Rigidbody2D>();
        component.mass = mass;
        component.gravityScale = 0;
        return this;
    }

    public BulletPhysicsBuilder Transform(Transform pos)
    {
        var component = GetOrAddComponent<Transform>();
        component.position = new Vector3(pos.position.x, pos.position.y, pos.position.z);
        return this;
    }

    private T GetOrAddComponent<T>() where T : Component
    {
        var result = gameObject.GetComponent<T>();
        if (!result)
        {
            result = gameObject.AddComponent<T>();
        }
        return result;
    }
}