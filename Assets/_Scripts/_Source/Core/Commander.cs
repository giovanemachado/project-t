namespace RouteTeamStudios.Core
{
    public abstract class Commander
    {
        protected enum Method
        {
            AWAKE,
            START,
            UPDATE
        }

        public abstract void OnAwake();

        public abstract void OnStart();

        public abstract void OnUpdate();

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