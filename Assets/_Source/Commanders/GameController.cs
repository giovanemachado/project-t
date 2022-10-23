using RouteTeamStudio.Utility;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace RouteTeamStudio.Commanders
{
    public class GameController : Singleton<GameController>
    {
        GameService gameService;

        protected override void Awake()
        {
            base.Awake();

            DontDestroyOnLoad(this.gameObject);

            gameService = new GameService();
        }

        public void PlayGame()
        {
            gameService.PlayGame();
        }

        public void QuitGame()
        {
            gameService.QuitGame();
        }
    }
}
