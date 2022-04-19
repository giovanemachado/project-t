using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasesManager : MonoBehaviour
{
    public GameObject MainMenuStateText;
    public GameObject PlayingStateText;
    public GameObject PausedStateText;

    void Awake()
    {
        GameManager.OnGameStateChange += GameManagerOnGameStateChanged;


    }
    void OnDestroy()
    {
        GameManager.OnGameStateChange -= GameManagerOnGameStateChanged;
    }

    void GameManagerOnGameStateChanged(GameState state)
    {
        if (state == GameState.MainMenu)
        {
            MainMenuStateText.SetActive(true);

            PlayingStateText.SetActive(false);
            PausedStateText.SetActive(false);
        }

        if (state == GameState.Playing)
        {
            PlayingStateText.SetActive(true);

            MainMenuStateText.SetActive(false);
            PausedStateText.SetActive(false);
        }

        if (state == GameState.Paused)
        {
            PausedStateText.SetActive(true);

            MainMenuStateText.SetActive(false);
            PlayingStateText.SetActive(false);
        }
    }
}
