using UnityEngine;

namespace RouteTeamStudio.Core
{
    public abstract class Controller : MonoBehaviour
    {
        public virtual void OnAwake() { }

        public virtual void OnStart() { }

        public virtual void OnUpdate() { }
    }
}