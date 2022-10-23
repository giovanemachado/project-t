using RouteTeamStudio.Gameplay.GameObject;
using RouteTeamStudio.Utility;
using UnityEngine;

namespace RouteTeamStudio.Commanders
{
    public class GameSceneController : MonoBehaviour
    {
        [SerializeField] GameObjectController gameObjectController;

        GameSceneService gameSceneService;

        void Awake()
        {
            gameSceneService = new GameSceneService(
                gameObjectController
            );

            gameSceneService.OnAwake();
        }

        void Start()
        {
            gameSceneService.OnStart();
        }

        void Update()
        {
            gameSceneService.OnUpdate();
        }
    }
}
