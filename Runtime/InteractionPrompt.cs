using UnityEngine;
using UnityEngine.UI;

namespace Studio1717.Interaction
{
    public sealed class InteractionPrompt : MonoBehaviour
    {
        [SerializeField] private Text label;

        public void SetText(string value)
        {
            if (label == null) return;
            if (label.text != value) label.text = value;
            label.enabled = !string.IsNullOrEmpty(value);
        }
    }
}
