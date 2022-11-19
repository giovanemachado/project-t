using RouteTeamStudio.Core;
using RouteTeamStudio.Gameplay.GameObjectC;
using UnityEngine;

namespace RouteTeamStudio.Commanders
{
    public class GameScene : Commander
    {
        [Header("Controllers")]
        [SerializeField] GameObjectC _gameObjectC;

        protected override void Awake()
        {
            base.Awake();
            ExecuteControllerMethod(_gameObjectC, Method.AWAKE);
        }

        protected void Start()
        {
            ExecuteControllerMethod(_gameObjectC, Method.START);
        }

        protected void Update()
        {
            ExecuteControllerMethod(_gameObjectC);
        }
    }
}
