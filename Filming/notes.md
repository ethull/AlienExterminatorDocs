# filming the video
## questions
- what video editor are we going to use
- how are we going to edit the video
- what parts of the game need to be in video

### what video editor are we going to use
- premier pro -
    - expensive, complex to use
- davinci resolve -
    - free version
    - is a bit complex
- mircosoft clipchamp
    - trial free version
    - corporate crap
- obs - // more for broadcasting then video editing
- openshot
- kdenlive


### how are we going to edit the video
- record bits of footage
- add subtitles or record voice over it

### breaking up longplay recording
- ai
    - patrolling
    - enemy detection -> follow and attack
- level progression
    - menu: show diff levels, saving data, reset save level/data
    - game: enemy spawning relative to level (increase number, increase spawn speed, more spawners
- guns and health (raycasting)
    - health
    - enemys attack
- other
    - menus
    - hud
    - pause menu
    - sfx and vfx

### order
-  shooting
- play menu
- pause menu
- reset progress
- gun shooting
- enemy damage
- collect first gun
-level complete
- spawning


### what parts of the game need to be in video
- 3 features
- all 3 levels

## links
- https://www.reddit.com/r/software/
- https://www.reddit.com/r/Filmmakers/
- https://www.reddit.com/r/editors

## scripts part of video
- ai
    - Insect Controller.cs
    - State.cs
    - patrol and GameEnvironment.cs
    - Chase, ChaseAttack, GetHit
- game progression
    - MainManager.cs
    - LevelManger.cs
    - LevelSelecUIManager.cs
    - InsectSpawner.cs
    - Inventory.cs
- guns and health
    - gun functionality / raycasting: Gun.cs
    - gun switcher: WeaponSwitcher.cs
    - weapon pickups: WeaponPickup.cs
    - Health.cs -> PlayerController.cs
    - Inventory