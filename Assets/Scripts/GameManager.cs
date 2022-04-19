using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class allow you to subscribe to the game state change event everywhere. 
/// </summary>
public class GameManager : Singleton<GameManager>
{
    public GameState State;

    public static event Action<GameState> OnGameStateChange;

    public void UpdateGameState(GameState newState)
    {
        State = newState;
        OnGameStateChange?.Invoke(newState);
    }

    void Start()
    {
        UpdateGameState(GameState.MainMenu);
    }
}
public enum GameState
{
    MainMenu,
    Playing,
    Paused
}

