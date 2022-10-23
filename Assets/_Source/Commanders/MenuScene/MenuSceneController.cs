using RouteTeamStudio.Utility;
using UnityEngine;

namespace RouteTeamStudio.Commanders
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
