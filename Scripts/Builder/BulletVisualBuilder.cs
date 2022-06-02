using UnityEngine;

public sealed class BulletVisualBuilder : BulletBuilder
{
    public BulletVisualBuilder(GameObject gameObject) : base(gameObject) { }

    public BulletVisualBuilder Name(string name)
    {
        gameObject.name = name;
        return this;
    }

    public BulletVisualBuilder Sprite(Sprite sprite)
    {
        var component = GetOrAddComponent<SpriteRenderer>();
        component.sprite = sprite;
        component.sortingOrder = 2;
        return this;
    }

    private T GetOrAddComponent<T>() where T : Component
    {
        var result = gameObject.GetComponent<T>();
        if(!result)
        {
            result = gameObject.AddComponent<T>();
        }
        return result;
    }

}