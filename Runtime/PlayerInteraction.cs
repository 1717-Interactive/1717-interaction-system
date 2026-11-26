using UnityEngine;
using UnityEngine.InputSystem;

namespace Studio1717.Interaction
{
    public sealed class PlayerInteraction : MonoBehaviour
    {
        [SerializeField] private Camera playerCamera;
        [SerializeField, Min(0.1f)] private float distance = 3f;
        [SerializeField] private LayerMask layers = ~0;
        [SerializeField] private InteractionPrompt prompt;
        [SerializeField] private Key interactionKey = Key.E;

        private void Update()
        {
            IInteractable target = null;
            if (playerCamera != null && Physics.Raycast(playerCamera.transform.position,
                playerCamera.transform.forward, out RaycastHit hit, distance, layers,
                QueryTriggerInteraction.Ignore))
            {
                target = hit.collider.GetComponentInParent<IInteractable>();
            }

            if (target != null && Keyboard.current != null &&
                Keyboard.current[interactionKey].wasPressedThisFrame)
            {
                target.Interact();
            }

            if (prompt != null)
                prompt.SetText(target == null ? string.Empty : $"[{interactionKey}] {target.Prompt}");
        }

        private void OnDisable()
        {
            if (prompt != null) prompt.SetText(string.Empty);
        }
    }
}
