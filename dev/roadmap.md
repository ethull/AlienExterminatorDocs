# roadmap
## initial -
- gather resources: assets, tutorials, EG projects
- import assets collected
- go through learning resources
  - lectures/slides/workshops/EGs, tutorials
  - shooting, enemy spawning, pathfinding and ai
## development
### step 1 enemys
- enemy functionality: basic
  - add basic enemy -
  - navmesh: follows the player -
  - AI behaviour and fsm animations -
    - detect player: attack -
    - fix stopping distance and attacking while idle
    - fix moving while still in idle animation
- add enemy spawning
  - map spawn points -
    - add > 1 spawn point -
    - get enemys to roam through the town -
- enemy functionality: more
  - enemy can reduce player health -
  - more AI behaviour and fsm animations
    - make them patrol through town -

### step 2 shooting
- add gun -
  - player can hold gun
  - gun can shoot
  - if hits enemy damage/kill it
- enemy -
  - take damage / health
  - death

### step 3 basic requirements
- add hud
  - enemy health
  - your health
  - remaining enemys / enemys left indicator
- add menus
  - basic menu for start and exit screens
- add sounds and effects to existing features

### step 4 additional
- add level flow
  - spawn certain number of enemys -
    - over time
    - relative to progress in level
  - adjust enemy spawning for diff levels
- add more enemys
  - boss: alien tripod?
  - ranged enemy (more hitscan ballistics)
- add fun mechanic
  - drops
  - pickups
    - ammo, coins
- add progression
  - player inventory
  - multiple guns
    - swap guns -
    - diff types
  - gun upgrades?
  - persistent save player guns to json

### step 5 time
- fix application bugs
- add new map
  - add multiple levels to new map
- add game optimisations
  - event managers
  - ...
