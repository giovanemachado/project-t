using UnityEngine;

namespace RouteTeamStudio.Core
{
    public abstract class Controller : MonoBehaviour
    {
        public virtual void OnAwake() { }

        /// <summary>
        /// OnAwake method for composition purposes, allow pass data through all sub classes.
        /// </summary>
        /// <param name="dataObject"></param>
        public virtual void OnAwake(ScriptableObject dataObject) { }

        public virtual void OnStart() { }

        public virtual void OnUpdate() { }
    }
}