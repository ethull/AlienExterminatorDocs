# notes

## what do i not understand 100%

### ai
- vector calculation for -
    - Attack.cs: facing the player // this script isnt used instead State.cs CanSeePlayer()
    - State.cs: Detecting the player (line of site calc)
- GameEnvironment: checkpoint singleton -
- State.cs: Exactly how the state loop works -

### game progression
- LevelSelectUIManager.cs: button hiding logic -
- MainManager.cs: Awake method, DontDestroyOnLoad, static instance -

### guns and health game mechanics
- Pickup.cs: bobbing animation -
- Health.cs: UnityActions (vs UnityEvents?) -
- Gun.cs: Raycast.All -
- InsectSpawner: Instantiate -
- Inventory.cs: AddWeapon (transform.localPosition / localRotation) -
- WeaponSwitcher.cs: transform list -