public abstract class BaseGameState
{
    public abstract void EnterState(GameManager gameManager);

    public abstract void UpdateState(GameManager gameManager);

    public virtual void ExitState(GameManager gameManager) { }
}