using UnityEngine;

namespace RouteTeamStudios.Core
{
    public abstract class Controller : MonoBehaviour
    {
        public virtual void OnAwake() { }

        public virtual void OnStart() { }

        public virtual void OnUpdate() { }
    }
}