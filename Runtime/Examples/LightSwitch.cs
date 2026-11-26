using UnityEngine;

namespace Studio1717.Interaction
{
    public sealed class LightSwitch : MonoBehaviour, IInteractable
    {
        [SerializeField] private Light targetLight;
        public string Prompt => targetLight != null && targetLight.enabled ? "Turn off light" : "Turn on light";

        public void Interact()
        {
            if (targetLight != null) targetLight.enabled = !targetLight.enabled;
        }
    }
}
