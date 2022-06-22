using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

internal sealed class Starter : MonoBehaviour
{
    [SerializeField] private BulletController bulletController;
    private TextController textController;
    [SerializeField] TMP_Text text;
    void Start()
    {
        textController = new TextController(bulletController, text);
    }
}