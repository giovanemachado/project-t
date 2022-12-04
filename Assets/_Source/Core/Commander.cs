using RouteTeamStudio.Utility;
using System.Collections.Generic;
using UnityEngine;

namespace RouteTeamStudio.Core
{
    public abstract class Commander : Singleton<Commander>
    {
        [SerializeField] protected List<Controller> controllers = new List<Controller>();

        protected enum Method
        {
            AWAKE,
            START,
            UPDATE
        }

        protected override void Awake()
        {
            base.Awake();

            foreach (Controller controller in controllers)
            {
                ExecuteControllerMethod(controller, Method.AWAKE);
            }
        }

        protected virtual void Start()
        {
            foreach (Controller controller in controllers)
            {
                ExecuteControllerMethod(controller, Method.START);
            }
        }

        protected virtual void Update()
        {
            foreach (Controller controller in controllers)
            {
                ExecuteControllerMethod(controller, Method.UPDATE);
            }
        }

        protected void ExecuteControllerMethod(Controller controller, Method method = Method.UPDATE)
        {
            if (
                method != Method.AWAKE &&
                !controller.gameObject.activeSelf
            )
            {
                return;
            }

            switch (method)
            {
                case Method.AWAKE:
                    controller.OnAwake();
                    break;
                case Method.START:
                    controller.OnStart();
                    break;
                case Method.UPDATE:
                    controller.OnUpdate();
                    break;
            }
        }

        protected void ExecuteControllerMethod(Controller[] controllers, Method method = Method.UPDATE)
        {
            foreach (Controller controller in controllers)
            {
                ExecuteControllerMethod(controller, method);
            }
        }
    }
}