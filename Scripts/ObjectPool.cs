using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

internal sealed class ObjectPool : IDisposable
{
    private readonly Stack<GameObject> _stack = new Stack<GameObject>();
    private readonly GameObject _prefab;
    private readonly Transform _root;

    public ObjectPool(GameObject prefab)
    {
        _prefab = prefab;
        _root = new GameObject($"[{_prefab.name}]").transform;
    }

    public GameObject Pop(Transform position)
    {
        GameObject go;
        if (_stack.Count == 0)
        {
            go = UnityEngine.Object.Instantiate(_prefab, position);
            go.name = _prefab.name;
        }
        else
            go = _stack.Pop();
        go.transform.position = position.position;
        go.SetActive(true);
        go.transform.SetParent(null);
        return go;
    }

    public void Push(GameObject go)
    {
        _stack.Push(go);
        go.transform.SetParent(_root);
        go.SetActive(false);    
    }


    public void Dispose()
    {
        for(var i = 0; i < _stack.Count; i++)
        {
            var gameObject = _stack.Pop();
            UnityEngine.Object.Destroy(gameObject);
        }
        UnityEngine.Object.Destroy(_root.gameObject);
    }
}
