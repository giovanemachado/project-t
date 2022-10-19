using UnityEngine;

namespace RouteTeamStudios.Core
{
    public abstract class Interactable : Controller
    {
        public enum InteractionType
        {
            Click
        }

        public InteractionType interactionType;

        public abstract string GetInteractionText();
        public abstract void Interact();
    }
}
