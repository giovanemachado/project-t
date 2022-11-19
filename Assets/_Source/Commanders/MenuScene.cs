using RouteTeamStudio.Core;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace RouteTeamStudio.Commanders
{
    public class MenuScene : Commander
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
