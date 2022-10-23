using RouteTeamStudio.Core;
using RouteTeamStudio.Gameplay.GameObject;

namespace RouteTeamStudio.Commanders
{
    public class GameSceneService : Commander
    {
        GameObjectController gameObjectController;

        public GameSceneService(
            GameObjectController gameObjectController
        )
        {
            this.gameObjectController = gameObjectController;
        }

        public override void OnAwake()
        {
            ExecuteControllerMethod(gameObjectController, Method.AWAKE);
        }

        public override void OnStart()
        {
            ExecuteControllerMethod(gameObjectController, Method.START);
        }

        public override void OnUpdate()
        {
            ExecuteControllerMethod(gameObjectController);
        }
    }
}
