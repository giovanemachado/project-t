using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class QuitState : BaseGameState
{
    public override void EnterState(GameManager gameManager)
    {
        Application.Quit();
    }

    public override void UpdateState(GameManager gameManager)
    {
        //
    }
}