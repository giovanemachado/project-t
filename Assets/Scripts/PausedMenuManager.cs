using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PausedMenuManager : MonoBehaviour
{
    public void ContinueButtonPressed()
    {
        GameManager.Instance.SwitchState(GameManager.Instance.PlayingState);
    }

    public void MenuButtonPressed()
    {
        GameManager.Instance.SwitchState(GameManager.Instance.MainMenuState);
    }
}
