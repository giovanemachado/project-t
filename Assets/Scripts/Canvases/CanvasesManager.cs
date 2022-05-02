using RouteTeamStudios.GameState;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace RouteTeamStudios.Canvases
{
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

        /// <summary>
        /// Show correct HUD
        /// </summary>
        void GameManagerOnGameStateChanged(BaseGameState state)
        {
            MainMenuCanvas.SetActive(state == GameManager.Instance.MainMenuState);
            HUDCanvas.SetActive(state == GameManager.Instance.PlayingState);
            PausedMenuCanvas.SetActive(state == GameManager.Instance.PausedState);
        }

        // Main Menu
        public void PlayButtonPressed()
        {
            GameManager.Instance.SwitchState(GameManager.Instance.PlayingState);
        }

        public void QuitButtonPressed()
        {
            GameManager.Instance.SwitchState(GameManager.Instance.QuitState);
        }

        // In game HUD
        public void PauseButtonPressed()
        {
            GameManager.Instance.SwitchState(GameManager.Instance.PausedState);
        }

        // Paused Menu
        public void ContinueButtonPressed()
        {
            GameManager.Instance.SwitchState(GameManager.Instance.PlayingState);
        }

        public void MenuButtonPressed()
        {
            GameManager.Instance.SwitchState(GameManager.Instance.MainMenuState);
        }
    }

}