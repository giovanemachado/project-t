namespace RouteTeamStudios.GameState
{
    public abstract class BaseGameState
    {
        public virtual void EnterState(GameManager gameManager) { }

        public virtual void UpdateState(GameManager gameManager) { }

        public virtual void ExitState(GameManager gameManager) { }
    } 
}