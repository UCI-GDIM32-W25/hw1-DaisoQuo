[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1
## W1L2 In-Class Activity
- Objects
  - UI
     - Seeds planted UI, every plant +1 is seeds -1
     - Seeds remaining UI
  - Player
     - Movement W A S D
     - Unique player sprite
     - Space bar summons plant prefab
     - grabs from a plant seed list until no more seeds
  - Plants
     - Prefab
     - Unique plant sprite
     - Can’t move
     - Max 5

## Devlog
For HW1, my code was very similar to the break down in Week 1's class activity. For example, I had some straightforward code that set up the player's WASD movements in 
```
if (Input.GetKey(KeyCode.W)) // wasd controls for player
{
    _playerTransform.Translate(Vector3.up * _speed * Time.deltaTime);
}
```
but I also had some more indirect codes that called upon other methods to show the remaining seeds and seeds planted every time the player grabbed a plant prefab, as listed in a breakdown in the UI. In the code   "_plantCountUI.UpdateSeeds(_numSeedsLeft,_numSeedsPlanted); " I made sure the UI aligned with the player's actions while simultaenously keeping count of the plant's integar of 5 as listed in the plant breakdown.

Despite this though, something that wasn't fully addressed in my breakdown was how the number of seeds determined the game mechanics/layout of all the UI, player, and plants themselves. If there was no seeds to plant and instantiate a prefab, the player's space key would not longer have a purpose (since seeds would be >= 0) the code for plantSeed() would not be called, nor would the UI change anymore because the game has come to a halt. So while the breakdown did address the general functions/characteristics of each game component, it did not highlight the dependence on each other to keep the game mechanic running.

## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprites

## Prof comments
I gave you full marks for this Devog, but I think you could have given a few more details other than the player movement code to talk about how the code that you wrote was similar to the break-down activity. Give some more examples from code for your HW2 Devlog! :)

> So while the breakdown did address the general functions/characteristics of each game component, it did not highlight the dependence on each other to keep the game mechanic running.

This is an interesting point! I hope you take this discovery about how the game systems are interdependent into your break-downs for future projects, especially your final project in this class, as that one is going to be more complex than our homeworks.

Please consider formatting your break-down activities with the hyphen '-' symbol as suggested above, and remove the prompts. I also added some formatting to make your code appear in code blocks. Also, make sure your in-class activity and Devlog are in separate sections. This will make it a lot easier for me to read. See the [README formatting guide here](https://docs.github.com/en/get-started/writing-on-github/getting-started-with-writing-and-formatting-on-github/basic-writing-and-formatting-syntax).
