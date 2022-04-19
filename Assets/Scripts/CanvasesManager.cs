using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CanvasesManager : MonoBehaviour
{
    public GameObject MainMenuCanvas;
    public GameObject PausedMenuCanvas;
    public GameObject HUDCanvas;

    void Awake()
    {
        GameManager.OnGameStateChange += GameManagerOnGameStateChanged;
    }

    void OnDestroy()
    {
        GameManager.OnGameStateChange -= GameManagerOnGameStateChanged;
    }

    void GameManagerOnGameStateChanged(BaseGameState state)
    {
        MainMenuCanvas.SetActive(state == GameManager.Instance.MainMenuState);
        HUDCanvas.SetActive(state == GameManager.Instance.PlayingState);
        PausedMenuCanvas.SetActive(state == GameManager.Instance.PausedState);
    }
}
