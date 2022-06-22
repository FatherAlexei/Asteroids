using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

internal sealed class TextController : MonoBehaviour, IDisposable
{
    private readonly BulletController bulletController;
    private TMP_Text text;
    public TextController(BulletController bulletController, TMP_Text text)
    {
        this.bulletController = bulletController;
        this.text = text;
        this.bulletController.OnTriggerEnterChange += BulletOnTriggerEnterChange;
    }

    private void BulletOnTriggerEnterChange()
    {
        text.text = "Asteroid has been destroyed";
        StartCoroutine(Immortal());
    }

    IEnumerator Immortal()
    {
        yield return new WaitForSeconds(1);
        text.text = "";
    }

    public void Dispose()
    {
        bulletController.OnTriggerEnterChange -= BulletOnTriggerEnterChange;
    }
}