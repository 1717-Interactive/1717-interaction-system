using UnityEngine;

namespace Studio1717.Interaction
{
    public sealed class Door : MonoBehaviour, IInteractable
    {
        [SerializeField] private float openAngle = 90f;
        [SerializeField, Min(1f)] private float speed = 180f;
        private Quaternion closedRotation;
        private bool isOpen;

        public string Prompt => isOpen ? "Close door" : "Open door";

        private void Awake() => closedRotation = transform.localRotation;

        public void Interact() => isOpen = !isOpen;

        private void Update()
        {
            Quaternion destination = closedRotation * Quaternion.Euler(0f, isOpen ? openAngle : 0f, 0f);
            transform.localRotation = Quaternion.RotateTowards(transform.localRotation, destination, speed * Time.deltaTime);
        }
    }
}
