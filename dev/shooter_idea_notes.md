# alien tripod: alien exterminator

## summary / desc
- 3D shooter
- maps with multiple levels
- enemys spawn in the map relative to the level

## components / features //what we want to do
- menu
- maps
- gameplay
### menu
- home screen
  - single player or split screen
- map/level selection
- store //pf
### maps
- enclosed area
- each map has a certain number of levels
- enemys spawn at certain points around the map at certain times
- each level spawns a diff num of enemys
- enemys find their way around the map and too the player
### gameplay
- enemys
  - diff enemy types: melee, ranged, boss //pf (else just melee)
  - enemy drops //pf
    - drop coins/ammo //pf
    - drop new weapons //pf
  - visual effect on death and attack
  - sound on death and attack
- weapons
  - diff weapons
    - unlocked after levels
    - diff damage/ fire rate
  - weapon store //pf
  - ammo //pf
  - sound/effect on shoot //pf
- ui/hud
  - player health
  - level progress
  - gun crosshairs
  - ammo left //pf
  - gold picked up? //pf
  - gun switcher //pf
- progress
  - levels, weapons, gold, ammo?

## major features
- advanced enemy pathfinding //will need to do bomberghost
- split screen //connect additional controllers
- possible lan multiplayer //if time

## requirements (to achieve features) //how we are gonna do it
- menus: design and images (assets)
- maps: 
  - map design and assets
  - enemy spawning and pathfinding
- enemys
  - assets: models
  - sounds
  - effects
  - pathfinding
- player
  - controls
  - gun models
- weapons
  - assets: models
  - sounds
  - effects
- enemys moving around the map
- pass enemy player inventory (guns, coins, ammo, levels): json file storage

## dev roadmap
- get menus done
- get enemys working
  - models
  - spawning
  - pathfinding
- get player working
  - controls
- weapons
  - models
  - sounds
  - effects

## overall roadmap
- find assets
- find EG projects
- start development
