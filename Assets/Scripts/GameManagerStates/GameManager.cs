using RouteTeamStudios.Utilities;
using System;
using UnityEngine;

namespace RouteTeamStudios.GameState
{
    public class GameManager : Singleton<GameManager>
    {
        BaseGameState state;

        [HideInInspector] public MainMenuState MainMenuState = new MainMenuState();
        [HideInInspector] public PlayingState PlayingState = new PlayingState();
        [HideInInspector] public PausedState PausedState = new PausedState();
        [HideInInspector] public QuitState QuitState = new QuitState();

        public static event Action<BaseGameState> OnGameStateChange;

        void Start()
        {
            InitStateAndInvokeEvent(MainMenuState);
        }

        void Update()
        {
            state.UpdateState(this);
        }

        public void SwitchState(BaseGameState newState)
        {
            state.ExitState(this);

            InitStateAndInvokeEvent(newState);
        }

        void InitStateAndInvokeEvent(BaseGameState initState)
        {
            state = initState;
            OnGameStateChange?.Invoke(state);
            state.EnterState(this);
        }
    } 
}
