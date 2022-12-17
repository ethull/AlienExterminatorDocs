# problems
## open in unity doesnt work
- firefox button doesnt work
- brave button works but xdg-open cant find the unity uri
- sol
  - add to my assets
  - download from unity package manager
- open in unity doesnt work ubuntu
  - https://forum.unity.com/threads/how-to-open-in-unity-from-asset-store-linux-mint-17-1.368095/
  - https://answers.unity.com/questions/1864431/cannot-log-in-unity-hub-3-on-ubuntu-xdg-open-fails.html
  - https://docs.unity3d.com/Manual/Packages.html

## ai
### aliens dont stop in front of the target
- https://stackoverflow.com/questions/44187141/unity-navmesh-follow-stop-certain-distance-away-from-target
- change stopping distance in chaseattack, but make sure to lower it again in patrol
### patrol bug
- agents are stopping before they reach checkpoints
- and the GameEnvironment static singleton is not updating the checkpoint refs between scenes
- https://gamedev.stackexchange.com/questions/147557/navmesh-stops-working-when-changing-scenes

## level manager
### scene changes as soon as level is over (no wait or level fail/clear music)
- https://answers.unity.com/questions/1397658/wait-1-second-before-changing-scene.html
- https://stackoverflow.com/questions/52722160/in-unity-after-loadscene-is-there-common-way-to-wait-all-monobehaviourstart-t
### having persistent data //is this a problem, i think this is a feature
- https://learn.unity.com/tutorial/implement-data-persistence-between-scenes-1
- https://learn.unity.com/tutorial/implement-data-persistence-between-sessions

## sounds
- https://soundbible.com/ //getting sfx sounds
- https://gamedevbeginner.com/how-to-play-audio-in-unity-with-examples/#clip_at_point

## pause menu
### cursor does not unlock properlly when changing to pause menu
- lock/unlock it manually, use tab instead of escape to avoid escaping out the editor
- https://gamedevbeginner.com/how-to-lock-hide-the-cursor-in-unity/

## main menus
### cursor wont show after changing scene
- https://answers.unity.com/questions/558398/cursor-not-shown-after-changing-scene.html
### buttons not working
- https://answers.unity.com/questions/1148727/ui-button-not-working-2.html
### problems changing scenes // feature or problem?
- https://gamedev.stackexchange.com/questions/73339/should-i-use-scenes-in-unity-for-menus
### saving data between scenes // feature or problem?
- https://docs.unity3d.com/ScriptReference/Application-persistentDataPath.html
- https://gamedev.stackexchange.com/questions/153707/how-to-get-current-scene-name
- https://stackoverflow.com/questions/64237669/unity-how-to-switch-scenes-and-when-returning-to-the-original-scene-return-pla