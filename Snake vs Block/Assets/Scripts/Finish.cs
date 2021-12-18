using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    public Game _game;
    private void OnTriggerEnter(Collider other)
    {
        _game.OnPlayerFinish();
    }
}
