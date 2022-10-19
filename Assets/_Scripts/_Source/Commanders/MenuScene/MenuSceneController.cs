using RouteTeamStudios.Utility;
using UnityEngine;

namespace RouteTeamStudios.Commanders
{
    public class MenuSceneController : MonoBehaviour
    {
        MenuSceneService menuSceneService;

        void Awake()
        {
            menuSceneService = new MenuSceneService();

            menuSceneService.OnAwake();
        }

        void Start()
        {
            menuSceneService.OnStart();
        }

        void Update()
        {
            menuSceneService.OnUpdate();
        }
    }
}
