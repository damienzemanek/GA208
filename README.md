# GA208
### Damien Zemanek
# W1
### Activity 1
<hr>

- Q1: 10
- Q2: 2
- Q3: prints: hello world
- Q4: Monobehaviour
- Q5: prints: x = 10
- Q6: Both are arguements, meant to pass in values to a method
- Q7: Transform is wrong, will not compile due to Translate being an instance method
- Q8: Transform should be replaced with either _playerTransform or transform depending on the context

### Activity 2
<hr>

[Google Doc Link Activity 2](https://docs.google.com/document/d/1RHdwQ6bJwzm1yvrqXCDy2VgBkrWVfvVI6CLvcCByLD8/edit?usp=sharing)

<img width="600" height="440" alt="a graphic breakdown of MG1" src="https://github.com/damienzemanek/GA208/blob/main/W1Script2.png?raw=true" />

## MG1

### Devlog
<hr>

Asset Procurement:
- I looked online for an image of a bunny and a sapling, collected, and imported them
- I made a new folder called W1 in the main directory, and inside that a folder called `Assets` and in a folder in that called `Sprites`
- I set them to `Single` for their sprite mode, and their compression to `High Quality` then Applied.

Scene Setup:
- I added 2 Square 2D GameObjects and changed their Sprite Renderer Sprite asset to the respective assets, and named them accordingly
- I created a new folder in W1 called `Scripts` and created a `Player` Script
- I added that script to the Player GameObject
- Before editing the script I added another 2D Square GameObject named it `Ground` and sized it to fit the scene

Programming:
- I opted to use old input system syntax cause its very quick and easy to use
- I created 2 polling methods, 1 for Moving, and 1 for spawning the seeds
- I put both in Update()
- I then added FixedUpdate() and put the Translate in there with a isMoving guard clause before it
- I made sure to correctly setup my variable attributes with ReadOnly if they werent settings
- And also add [Required] for references. (These are ODIN attributes), This is a best practice for me
- I opted to use OnEnable for the setup, updating the UI and setting the current seeds count
- I extracted out the update ui code in its own UpdateUI() method cause it appeared twice, (once in the seed placement and once in OnEnable)

Scene Completing Setup:
- I then imported the TMPro package requirements and added the text, and added them as references
- I had 4 TMPro texts, 2 labels, and 2 number trackers so I didnt have to add any string literals into the code (Just a preference), plus it looks better in the canvas
- I added in all my references, including making a Prefab out of the seed sprite, and mades its OrderInLayer to be behind the player

Building:
- I added the Web build package. And tried building.
- The build failed twice due to scripts `MaterialRandomizer` and `MaterialRandomizerScript` being editor scripts trying to include themselves
- I added the `#if UNITY_EDITOR ... #endif` compiler checks to remove them from the build
- After that the build worked.
- I zipped up my files and uploaded it to Itch.


### Open Source Assets

- [Player Sprite](https://www.clipartmax.com/middle/m2i8i8A0A0H7A0Z5_free-bunny-in-overalls-front-view-overall-clip-art/)
- [Seed Sprite](https://www.vecteezy.com/png/15082209-sapling-sprouting-from-soil)

<hr>

