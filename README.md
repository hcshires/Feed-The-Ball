# Feed The Ball - Unity 3D Platfomer

A 3D platformer built in Unity 3D with C#. Play as a spherical character and collect fancy, spining gold coins while avoiding the pesky pills of doom! Advance to the next level by collecting all the coins in the level and reaching the green pad.

## Full Project Description
“Feed the Ball” is a fast-paced, interactive 3D Game involving a ball rolling on a field, attempting to avoid enemies, while collecting coins and power-ups to advance to the next level. Levels become increasingly difficult based entirely on the player’s determined skill level based on a custom Machine Learning (ML) algorithm written with the Unity MLAgents SDK. The purpose of the ML implementation is simply to give this simple idea for a game a unique twist and gives a reason to give a pledge. This increases the User Experience (UX) of the game and provides an increased learning opportunity for the developer.

## Gameplay
Players will be greeted with a title screen containing “play” and “settings” buttons (detailed functionality included in Pseudocode). Players are shown the beginning scene. Players move the on-screen ball with W, A, S, D, or Arrow keys. Players can collect “coins” to increase their score and unlock the next level, “power-ups” to unlock special abilities for quicker completion of the level, and to avoid “enemies”. “Power-ups” allow the player to eliminate the enemies on-screen and avoid getting “hit”. As the player progresses, the level’s difficulty should increase based on the amount of time it takes them to complete a level, the strategies they are using, and how they are utilizing on-screen elements. If the player fails to complete a level by losing all their “lives”, the level starts over. Levels can be selected in the “game menu” by pressing M or the on-screen button. The player can quit the level or the game altogether from the same menu and save their progress.

## Purpose

### Problem Statement:
How can I as a software developer, create a 3D platform/shooter game with ML implementation, to attract players and generate income to donate to charity?

### Solution - Philanthropy Model:
Players of “Feed the Ball” can pledge an amount on a crowdfunding project page that will go directly to charity. Kickstarter is the platform that allows the developed game to be able to generate income for charity (versus an alternate fundraiser).

## Game Includes
- 3 Levels with unique obstacles and game objects
- Enemy bodies and platform structures
- Custom, dumb textures
- Scoring and instructions
- Level selection and main menu

![Feed The Ball screenshot](https://hcshires.github.io/assets/images/feed-the-ball.jpg)

A working version can be viewed and played at [https://hcshires.github.io/games/feed-the-ball](https://hcshires.github.io/games/feed-the-ball)

View my presentation slides: https://hcshires.github.io/assets/files/feed-the-ball-slides.pptx

## Known Issues
- After selecting a level from the level selection screen, more than one ball characters spawn
- Controlling the ball is too realistic and not user-friendly/makes the game hard to play
- No end game (nothing happens after level 3)
