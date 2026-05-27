# Car Obstacle Game

[![Unity](https://img.shields.io/badge/Unity-2021.3%2B-black?logo=unity)](https://unity.com/)
[![C#](https://img.shields.io/badge/Language-C%23-239120?logo=csharp&logoColor=white)](https://learn.microsoft.com/dotnet/csharp/)
[![License](https://img.shields.io/badge/License-MIT-green.svg)](LICENSE)
[![Platform](https://img.shields.io/badge/Platform-PC-blue)](https://unity.com/)
[![Status](https://img.shields.io/badge/Status-Playable-brightgreen)](README.md)

> A compact 3D Unity driving game where you steer through a low-poly road course, collect coins, avoid obstacles, and reach the finish line to win.

## Table of Contents

- [Overview](#overview)
- [Features](#features)
- [Gameplay Mechanics](#gameplay-mechanics)
- [Controls](#controls)
- [Technologies Used](#technologies-used)
- [Unity Version Compatibility](#unity-version-compatibility)
- [Folder Structure](#folder-structure)
- [Scripts and Modules](#scripts-and-modules)
- [Installation and Setup](#installation-and-setup)
- [How to Play](#how-to-play)
- [Screenshots](#screenshots)
- [Future Improvements](#future-improvements)
- [Contribution Guidelines](#contribution-guidelines)
- [License](#license)
- [Author](#author)

## Overview

Car Obstacle Game is a Unity-based obstacle driving game built around a simple and readable gameplay loop: drive forward, collect score pickups, avoid hazards, and hit the finish trigger to win. The project includes a menu scene, pause/resume flow, game-over handling, and scene restart logic, making it a solid example of core Unity gameplay systems working together.

The repository is especially suitable for a portfolio because it demonstrates practical use of Unity physics, trigger events, UI panels, scene management, TextMesh Pro, and chase-camera behavior in a small but complete game.

## Features

- 🚗 Third-person car movement with steering and forward drive
- 🪙 Coin pickups with score updates
- 💥 Obstacle collision detection with game-over state
- 🏁 Finish trigger with win screen
- ⏸️ Pause, resume, and restart flow
- 🎥 Simple camera follow system for gameplay visibility
- 🖥️ Main menu with play and quit actions
- 🎨 Imported low-poly road and vehicle assets

## Gameplay Mechanics

| Mechanic | Description |
| --- | --- |
| Movement | The player car uses the vertical axis for forward motion and the horizontal axis for rotation. |
| Collision | Colliding with objects tagged as `Obstacle` activates the game-over panel and pauses time. |
| Collectibles | Coins use trigger detection to increment score and are removed after pickup. |
| Win state | Entering the finish trigger displays the win panel and freezes the game. |
| Restart flow | Win and game-over states both support restarting the current scene. |
| Camera | The camera follows the car using a fixed offset to maintain a chase view. |

## Controls

| Input | Action |
| --- | --- |
| `W` / `S` or `Up` / `Down` | Move the car forward or backward |
| `A` / `D` or `Left` / `Right` | Rotate the car left or right |
| Mouse / UI buttons | Navigate menu, pause, restart, and quit actions |

## Technologies Used

| Technology | Purpose |
| --- | --- |
| Unity | Game engine, scenes, physics, and UI |
| C# | Gameplay scripting and scene control |
| TextMesh Pro | Score and UI text rendering |
| Unity Input Manager | Keyboard input handling |
| Unity Physics | Collisions and trigger events |
| Universal Render Pipeline | Rendering pipeline setup |

## Unity Version Compatibility

Recommended for **Unity 2021.3 LTS or newer**.

This project uses the legacy Input Manager API (`Input.GetAxis`), standard Unity physics callbacks, scene loading, and TextMesh Pro. Those systems are broadly supported across LTS releases, so the project should open cleanly in modern Unity versions without a large migration effort.

## Folder Structure

| Path | Purpose |
| --- | --- |
| `Scenes/` | Main menu, sample scene, and road demo scenes |
| `Resources/` | Runtime and test metadata used by Unity |
| `ARCADE - FREE Racing Car/` | Imported racing car and road environment assets |
| `BrokenVector/` | Low-poly road pack content |
| `Obstacle Pack/` | Obstacle models, prefabs, and materials |
| `SportCar/` | Vehicle asset pack and related configuration files |
| `PolyKebap/` | Additional asset-pack content used by the project |
| `SyntyStudios/` | Imported Synty assets and metadata |
| `TextMesh Pro/` | TMP resources and supporting files |
| Root `*.cs` files | Core gameplay scripts for movement, UI, scoring, and scene flow |

## Scripts and Modules

| Script | Responsibility |
| --- | --- |
| `playerMovement.cs` | Reads input and moves/rotates the player vehicle. |
| `cameraFollow.cs` | Keeps the camera aligned to the player with a fixed offset. |
| `PlayerCollision.cs` | Shows the game-over UI when the player collides with obstacles. |
| `Coin.cs` | Handles coin pickup scoring and destroys collected coins. |
| `CoinCollectible.cs` | Alternate collectible script for pickup interaction. |
| `ScoreManager.cs` | Singleton score system that updates the TextMesh Pro display. |
| `gameManager.cs` | Controls pause, resume, and scene restart actions. |
| `MainMenu.cs` | Starts the game scene or quits the application from the menu. |
| `WinCondition.cs` | Detects the finish trigger and shows the win panel. |
| `SportCar/Settings/Racing_Game.cs` | Asset-pack support script included with the imported vehicle content. |

## Installation and Setup

1. Clone or download the repository.
2. Open the project folder in Unity Hub.
3. Select a compatible editor version, ideally **Unity 2021.3 LTS or newer**.
4. Let Unity import the project assets and resolve packages.
5. Open `Scenes/Main Menu.unity`.
6. Press Play to launch the game from the editor.

If references appear missing after import, verify that TextMesh Pro and the bundled asset packs are fully imported.

## How to Play

1. Launch the game from the main menu.
2. Use the keyboard controls to drive the car.
3. Avoid obstacles tagged `Obstacle`.
4. Collect coins to raise your score.
5. Reach the finish trigger to complete the level.
6. Use the on-screen restart button after a win or loss to play again.

## Screenshots

Add exported screenshots here to showcase the game visually in the repository.

### Gameplay Preview

![Gameplay Screenshot](docs/screenshots/gameplay.png)

### Main Menu

![Main Menu Screenshot](docs/screenshots/main-menu.png)

### Game Over

![Game Over Screenshot](docs/screenshots/game-over.png)

### Win Screen

![Win Screen Screenshot](docs/screenshots/win-screen.png)

## Future Improvements

- Add gamepad and touch input support
- Expand the game into multiple levels or courses
- Improve vehicle physics and steering feel
- Add music, sound effects, and feedback polish
- Introduce high scores and run statistics
- Unify collectible scripts into a single pickup system
- Add a settings menu for audio and graphics options

## Contribution Guidelines

Contributions are welcome. If you plan to improve the project:

1. Fork the repository.
2. Create a feature branch.
3. Keep changes focused and well named.
4. Test the project in Unity before submitting a pull request.
5. Match the existing scene, naming, and script conventions.

## License

This project is licensed under the [MIT License](LICENSE).

You may use, modify, and distribute the project under the terms in the license file.

## Author

**Muhammad Zeeshan Islam**

If you use this project in your portfolio or build on top of it, please keep the attribution and license notice intact.

