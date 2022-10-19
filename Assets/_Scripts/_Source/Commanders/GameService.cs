using UnityEngine;
using UnityEngine.SceneManagement;

namespace RouteTeamStudios.Commanders
{
    public class GameService
    {
        public void PlayGame()
        {
            SceneManager.LoadScene("GameScene");
        }

        public void QuitGame()
        {
            Application.Quit();
        }
    }
}
