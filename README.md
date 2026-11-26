# 1717 Interaction System

A lightweight modular interaction package for Unity 6, credited to Centolinho and 1717 Interactive.

## Installation

Extract the folder. In Unity Package Manager choose **Install package from disk** and select `package.json`. Requires Unity Input System and Unity UI (installed as package dependencies). Set Active Input Handling to Input System Package or Both in Player Settings.

## Setup

1. Add PlayerInteraction to your player and assign its camera.
2. Create a Canvas with a legacy UI Text element. Add InteractionPrompt to the Canvas and assign the Text. Assign the prompt component to PlayerInteraction.
3. Create a door with a collider and a hinge pivot. Attach Door to the pivot, with the collider on the pivot or a child. Set the opening angle and speed.
4. Create a switch with a collider and LightSwitch; assign a Light.
5. Enter Play mode, aim at an object within range and press E. Use an existing player controller or move the camera manually in the editor. Ensure the raycast layer mask excludes the player and includes the target.

## Extension

Implement IInteractable on a MonoBehaviour and provide a Prompt property and Interact method. The raycast resolves the interface on the hit collider or its parents. Solid obstacles block interaction.

## Validation

Manual checks: aim at each object, toggle twice, move out of range, place a solid obstacle between camera and target, disable PlayerInteraction and verify the prompt clears. This package has not been compiled or play-tested in Unity in this environment. No player controller or prebuilt scene is included.

## Credits

Centolinho — 1717 Interactive. Initial implementation assisted by AI.

Contact: 1717interactive@gmail.com

MIT License.
