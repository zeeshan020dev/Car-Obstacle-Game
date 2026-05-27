# Car Obstacle Game

[![Unity](https://img.shields.io/badge/Unity-2021.3%2B-black?logo=unity)](https://unity.com/)
[![License](https://img.shields.io/badge/License-MIT-green.svg)](LICENSE)
[![Platform](https://img.shields.io/badge/Platform-PC-blue)](https://unity.com/)
[![Status](https://img.shields.io/badge/Status-Playable-brightgreen)](README.md)

> A fast-paced 3D car obstacle game built in Unity where the player drives through a low-poly road environment, collects coins, avoids hazards, and reaches the finish line to win.

## Overview

Car Obstacle Game is a Unity-based driving game focused on simple, responsive gameplay and clear win/lose conditions. The player controls a car using keyboard input, navigates road environments assembled from asset-pack content, collects score-boosting coins, and must avoid obstacle collisions that trigger a game-over state. The project also includes a main menu, pause/resume flow, restart logic, and a dedicated victory trigger.

This repository is well suited for a portfolio because it demonstrates core Unity systems working together: physics-based collisions, trigger interactions, UI state management, scene loading, camera follow behavior, and TextMesh Pro score updates.

## Features

- 🚗 Player-controlled car movement with forward motion and steering
- 🪙 Collectible coin system with score tracking
- 💥 Obstacle collision handling and game-over UI
- 🏁 Win-condition trigger at the finish point
- ⏸️ Pause, resume, and restart controls
- 🎥 Third-person camera follow behavior
- 🖥️ Main menu scene with play and quit actions
- 🎨 Low-poly racing environment using imported asset packs

## Gameplay Mechanics

| Mechanic | Description |
| --- | --- |
| Movement | The player car moves with the vertical input axis and rotates with the horizontal axis. |
| Collision | Hitting objects tagged as Obstacle activates the game-over panel and pauses the game. |
| Collectibles | Coins use trigger detection to award points and disappear after pickup. |
| Win state | Reaching the finish trigger shows the win panel and freezes time. |
| Restart flow | Both game-over and win states support restarting the current scene. |
| Camera | The camera follows the car with a fixed positional offset for a chase-view setup. |

## Technologies Used

| Technology | Purpose |
| --- | --- |
| Unity | Game engine and scene management |
| C# | Gameplay scripting |
| TextMesh Pro | Score UI rendering |
| Unity Input Manager | Keyboard movement input |
| Unity Physics | Collisions and trigger events |
| Universal Render Pipeline | Modern rendering setup |

## Unity Version Compatibility

Recommended for **Unity 2021.3 LTS or newer**.

This project uses the legacy Input Manager API (`Input.GetAxis`), TextMesh Pro, scene loading, and standard Unity physics callbacks. It should remain compatible with Unity versions that support these systems without additional package migration.

## Folder Structure

| Path | Purpose |
| --- | --- |
| `Scenes/` | Main gameplay, menu, and sample scenes |
| `Resources/` | Runtime resource and test metadata |
| `ARCADE - FREE Racing Car/` | Road, skybox, texture, and vehicle asset-pack content |
| `BrokenVector/` | Low-poly road pack assets |
| `Obstacle Pack/` | Obstacle models, prefabs, materials, and related assets |
| `SportCar/` | Car asset pack content and settings |
| `PolyKebap/` | Additional collectible or gameplay-related assets |
| `SyntyStudios/` | Imported Synty asset-pack content |
| `TextMesh Pro/` | TMP resources and package support files |
| `*.cs` files in root | Gameplay scripts controlling player, UI, scoring, and scenes |

## Scripts and Modules

| Script | Responsibility |
| --- | --- |
| `playerMovement.cs` | Reads horizontal and vertical input to move and rotate the player car. |
| `cameraFollow.cs` | Keeps the camera positioned behind the player with a fixed offset. |
| `PlayerCollision.cs` | Detects obstacle collisions and shows the game-over panel. |
| `Coin.cs` | Awards score when the player collects a coin and destroys the pickup. |
| `CoinCollectible.cs` | Alternate collectible script that handles pickup detection and object removal. |
| `ScoreManager.cs` | Singleton score controller that updates the TextMesh Pro score label. |
| `gameManager.cs` | Handles pause, resume, and restart behavior for the active scene. |
| `MainMenu.cs` | Main menu actions for starting the game and quitting the application. |
| `WinCondition.cs` | Detects the finish trigger, shows the win panel, and allows restart. |
| `SportCar/Settings/Racing_Game.cs` | Asset-pack support or configuration script bundled with the imported car content. |

## Installation and Setup

1. Clone or download this repository.
2. Open the project folder in Unity Hub.
3. Use a compatible Unity version, preferably **2021.3 LTS or newer**.
4. Let Unity import the assets and resolve any package prompts.
5. Open the `Scenes/Main Menu.unity` scene to begin.
6. Press Play to test the menu and load into gameplay.

If the project opens with missing references, make sure the imported asset packs and TextMesh Pro resources are fully imported.

## How to Play

1. Start from the main menu and launch the game.
2. Use the keyboard controls to drive the car.
3. Avoid obstacle objects tagged as `Obstacle`.
4. Collect coins to increase your score.
5. Reach the finish trigger to win.
6. Use the restart button on the win or game-over screen to try again.

## Screenshots

Add your exported images here to make the repository more visually compelling.

### Gameplay Preview

![Gameplay Screenshot](docs/screenshots/gameplay.png)

### Main Menu

![Main Menu Screenshot](docs/screenshots/main-menu.png)

### Game Over

![Game Over Screenshot](docs/screenshots/game-over.png)

### Win Screen

![Win Screen Screenshot](docs/screenshots/win-screen.png)

## Future Improvements

- Add touch or gamepad controls for broader platform support
- Introduce multiple levels with increasing obstacle complexity
- Improve vehicle physics and drifting behavior
- Add sound effects, background music, and polish effects
- Expand UI with countdown, combo, and high-score systems
- Replace placeholder collectible logic with one unified pickup system
- Add an options menu for volume and graphics settings

## Contribution Guidelines

Contributions are welcome. If you want to improve the project:

1. Fork the repository.
2. Create a feature branch.
3. Make focused changes with clear commit messages.
4. Test the project in Unity before opening a pull request.
5. Keep changes consistent with the current scene and script structure.

## License

This project is licensed under the [MIT License](LICENSE).

You are free to use, modify, and distribute the code under the terms described in the license file.

## Author

**Muhammad Zeeshan Islam**

If you use this project in your portfolio or as a base for a new game, please credit the original author and keep the license notice intact.

