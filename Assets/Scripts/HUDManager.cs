using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDManager : MonoBehaviour
{
    public void PauseButtonPressed ()
    {
        GameManager.Instance.SwitchState(GameManager.Instance.PausedState);
    }
}
