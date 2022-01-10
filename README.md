# Feed The Ball - Unity 3D Platfomer

A 3D platformer built in Unity 3D with C#. Play as a spherical character and collect fancy, spining gold coins while avoiding the pesky pills of doom! Advance to the next level by collecting all the coins in the level and reaching the green pad.

## Game Includes
- 3 Levels with unique obstacles and game objects
- Enemy bodies and platform structures
- Custom, dumb textures
- Scoring and instructions
- Level selection and main menu

![Feed The Ball screenshot](https://hcshires.github.io/assets/images/feed-the-ball.jpg)

- A working version can be viewed and played at [https://hcshires.github.io/games/feed-the-ball](https://hcshires.github.io/games/feed-the-ball)
- View my presentation slides: https://hcshires.github.io/assets/files/feed-the-ball-slides.pptx

## Known Issues
- After selecting a level from the level selection screen, more than one ball characters spawn
- Controlling the ball is too realistic and not user-friendly/makes the game hard to play
- No end game (nothing happens after level 3)

**Below is additional information about my game written to satisfy the requirements of the AP Computer Science Principles May 2019 Create task.**

## Full Project Description
“Feed the Ball” is a fast-paced, interactive 3D Game involving a ball rolling on a field, attempting to avoid enemies, while collecting coins and power-ups to advance to the next level. Levels become increasingly difficult based entirely on the player’s determined skill level based on a custom Machine Learning (ML) algorithm written with the Unity MLAgents SDK. The purpose of the ML implementation is simply to give this simple idea for a game a unique twist and gives a reason to give a pledge. This increases the User Experience (UX) of the game and provides an increased learning opportunity for the developer.

## Development
I used my own functions as well as Unity functions to add movement, collisions, score, and respawn, with each object using one script. The enemies follow similar logic as the player but continuously and without player input. In the player object, the player can use the keyboard to move the sphere and advance to the next level after crossing a checkpoint. The purpose of each item to create an engaging and entertaining environment for players to see how quickly and/or easily they can advance to the next level.

I first began developing my game independently by adding GameObjects to a Unity scene. These objects include walls, platforms, the player, coins, and enemies. Using tutorials from Unity as well as their documentation, I continued by adding movement to the player, allowed coins to be “collected”, and added logic to check for certain events such as running into an enemy or reaching a checkpoint. As I began working on the game objective, I identified a problem with my scoring system. Originally, I would check for the player to reach a certain score in order to reach the next level. Occasionally, this would not work properly, as I either miscounted the number of coin objects or the control flow of my personal function wasn’t accurate. I solved this problem by redesigning my algorithm to have the player touch a platform in addition to checking for a certain score. Another issue I ran into later was when I added new objects I wanted the player to interact/collide with, the object move or fall through it. I found that the object must be defined as a “trigger”. A trigger allows Unity to enable collisions, which fixed my issue and completed my game.

![image](https://user-images.githubusercontent.com/25646224/148729260-59bfcb49-2ad2-4f06-9ed0-98ccfb3568f2.png)
The GameController script is the biggest main set of algorithms in my program. GameController controls all logical and mathematical parts of my game to achieve the purpose of updating data on the screen to keep the game engaging and interactive. On line 53, FixedUpdate() contains math functions and expressions to check for input from the keyboard and change the player’s movement by a factor of the defined speed variable and to simulate friction. It then uses a combination of Unity functions and multiples that value again by deltaTime to convert the speed to a frame-by-frame factor. OnTriggerEnter() on line 79 uses if statements to check for if a player touches a coin, enemy, or checkpoint. It then calls SetText() which uses if statements to determine which level should the game advance to and what the on-screen instructions should be set to. Both OnTriggerEnter() and SetText() use if statements as sub algorithms to determine what data to output to either an abstracted function or directly to the screen. Each function in GameController work together to allow the player to control the player object, interact with the scene, and finish the objective of collecting coins and passing levels.

### Use of Abstraction
![image](https://user-images.githubusercontent.com/25646224/148729237-cd3b6687-70c4-46b9-a3aa-fac9546fc385.png)
The abstraction I selected is my own function, LevelChange() defined on line 45. LevelChange() handles how the game advances to the next “scene” file or level and is called in SetText() (see algorithm response) when the score reaches a certain amount and when the player crosses the green checkpoint. When the function is called, I input what level I want to advance to. The function then converts the input to a string that SceneManager can read, loads the scene, and repositions the player to the start of the level,. My abstraction manages complexity, since I need to use the exact same algorithm multiple times as there are multiple levels in my game to advance to. Without this abstraction, I would need to explicitly define in my code which level I want the game to progress to when a condition is met, which is more difficult, is less efficient, and takes more time. In addition, if there was an issue that required a redesign or I wanted to tweak a value, I would have to tweak each instance of that algorithm, but in my case here, I would only need to change it once, since it is an abstraction.

## Gameplay
Players will be greeted with a title screen containing “play” and “settings” buttons (detailed functionality included in Pseudocode). Players are shown the beginning scene. Players move the on-screen ball with W, A, S, D, or Arrow keys. Players can collect “coins” to increase their score and unlock the next level, “power-ups” to unlock special abilities for quicker completion of the level, and to avoid “enemies”. “Power-ups” allow the player to eliminate the enemies on-screen and avoid getting “hit”. As the player progresses, the level’s difficulty should increase based on the amount of time it takes them to complete a level, the strategies they are using, and how they are utilizing on-screen elements. If the player fails to complete a level by losing all their “lives”, the level starts over. Levels can be selected in the “game menu” by pressing M or the on-screen button. The player can quit the level or the game altogether from the same menu and save their progress.

## Additional Purpose

### Problem Statement:
How can I as a software developer, create a 3D platform/shooter game with ML implementation, to attract players and generate income to donate to charity?

### Solution - Philanthropy Model:
Players of “Feed the Ball” can pledge an amount on a crowdfunding project page that will go directly to charity. Kickstarter is the platform that allows the developed game to be able to generate income for charity (versus an alternate fundraiser).
