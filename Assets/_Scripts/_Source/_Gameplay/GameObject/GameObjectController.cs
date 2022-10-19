using RouteTeamStudios.Core;

namespace RouteTeamStudios.Gameplay.GameObject
{
    public class GameObjectController : Controller
    {
        GameObjectService gameObjectService;

        public override void OnAwake()
        {
            gameObjectService = new GameObjectService();
        }

        public void OnClickTest()
        {
            gameObjectService.OnClickTest();
        }
    }
}
