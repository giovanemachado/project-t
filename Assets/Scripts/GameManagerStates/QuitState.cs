using UnityEngine;

namespace RouteTeamStudios.GameState
{
    public class QuitState : BaseGameState
    {
        public override void EnterState(GameManager gameManager)
        {
            Application.Quit();
        }
    } 
}