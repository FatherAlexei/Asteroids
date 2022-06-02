using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBuilder
{
    protected GameObject gameObject;

    public BulletBuilder() => gameObject = new GameObject();

    protected BulletBuilder(GameObject gameObject) => this.gameObject = gameObject;

    public BulletVisualBuilder Visual => new BulletVisualBuilder(gameObject);

    public BulletPhysicsBuilder Physics => new BulletPhysicsBuilder(gameObject);

    public static implicit operator GameObject(BulletBuilder builder)
    {
        return builder.gameObject;
    }
}
