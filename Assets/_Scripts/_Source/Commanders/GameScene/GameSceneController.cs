using RouteTeamStudios.Gameplay.GameObject;
using RouteTeamStudios.Utility;
using UnityEngine;

namespace RouteTeamStudios.Commanders
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
