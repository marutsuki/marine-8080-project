**The University of Melbourne**
# COMP30019 – Graphics and Interaction

Final Electronic Submission (project): **4pm, Fri. 6 November**

Do not forget **One member** of your group must submit a text file to the LMS (Canvas) by the due date which includes the commit ID of your final submission.

You can add a link to your Gameplay Video here but you must have already submit it by **4pm, Sun. 25 October**

# Project-2 README

You must modify this `README.md` that describes your application, specifically what it does, how to use it, and how you evaluated and improved it.

Remember that _"this document"_ should be `well written` and formatted **appropriately**. This is just an example of different formating tools available for you. For help with the format you can find a guide [here](https://docs.github.com/en/github/writing-on-github).


**Get ready to complete all the tasks:**

- [x] Read the handout for Project-2 carefully

- [ ] Brief explanation of the game

- [ ] How to use it (especially the user interface aspects)

- [ ] How you modelled objects and entities

- [ ] How you handled the graphics pipeline and camera motion

- [ ] Descriptions of how the shaders work

- [ ] Description of the querying and observational methods used, including: description of the participants (how many, demographics), description of the methodology (which techniques did you use, what did you have participants do, how did you record the data), and feedback gathered.

- [ ] Document the changes made to your game based on the information collected during the evaluation.

- [ ] A statement about any code/APIs you have sourced/used from the internet that is not your own.

- [ ] A description of the contributions made by each member of the group.

## Table of contents
* [Team Members](#team-members)
* [Contributers](#contributers)
* [Explanation of the game](#explanation-of-the-game)
* [Technologies](#technologies)
* [Using Images](#using-images)
* [Code Snipets ](#code-snippets)
* [Brief explaination of the game](#brief-explaination-of-the-game)
* [How to use the game](#how-to-use-the-game)
* [How we modelled objects and entities](#how-we-modelled-objects-and-entities)
* [How we handled the graphics pipeline and camera motion](#how-we-handled-the-graphics-pipeline-and-camera-motion)
* [Description of how the shaders work](#discription-of-how-the-shaders-work)

## Team Members

| Name | Task | State |
| :---         |     :---:      |          ---: |
| Timmy Truong  | Shaders, Video Editing, Interface, Lighting and README     |![90%](https://progress-bar.dev/90)|
| Nathan Rearick    | Movement, Evaluation     |![90%](https://progress-bar.dev/90)|
| Lucien Lu    | Level design, Turrets/Projectiles, AI, Main Menu, Camera, Abilities, Special Movement, Guns, UI      |![95%](https://progress-bar.dev/95)|

## Contributers

| | Contributer | Contribution | Email | Other |
|---|---|---|---|---|
| <p align="center"><img src="kevingaoinsta.PNG"  width="300" ></p> | <b>Kevin Gao</b> | Turret and map assets modelling | kevin.haha@gmail.com | Instagram: https://www.instagram.com/keving_win98se/ |
## Explanation of the game
Our game is a first person shooter (FPS) that....

You can use emojis :+1: but do not over use it, we are looking for professional work. If you would not add them in your job, do not use them here! :shipit:

	
## Technologies
Project is created with:
* Unity 2019.4.3f1
* Ipsum version: 2.33
* Ament library version: 999

# Synopsis
You are Marine 8080, a newly recruited private, enrolled into the Special Space Marine Force. Your objective is to navigate throughout the 6 uniquely designed locations from start to the finish, activating every radar you come across. Of course, the opposition will not let you succeed so easily, as a scouting survey of the area reports that the facility is well armed, additionally indicating that a large source of energy is radiating from the centre.

You will have to be careful, as the human body can only tolerate so much damage. Run, jump and slide out of the barrage of ammunition that will be thrown at you. Don’t forget to take advantage of the arsenal of weapons and abilities that you will come across, you never know what could lie ahead of you.

# Description
Space Marine 8080 is a 2.5D platformer inspired by the game 'My Friend Pedro', where the main objective of the game is to shoot, move and reach the end of each level in style. The versatility and freedom that is offered to the player allows for them to play their own way, as there is no 'correct' way to complete a level.

# Weapons
The player has access to 4 different weapons, all with different strengths and weaknesses, allowing for the player to choose a playstyle or adapt to their environment.
## The Rifle
<b>Strengths</b>
<ul>
	<li>Long Range</li>
	<li>Moderate Rate of Fire</li>
	<li>Moderate Magazine Size</li>
	<li>Low Bullet Spread</li>
</ul>

<b>Weaknesses</b>
<ul>
	<li>Low Damage Per Second (DPS)</li>
	<li>Low Damage Per Shot</li>
</ul>
<p align="center">
  <img src="Gifs/2020-11-05_06-09-08.gif"  width="300" >
</p>

## The Shotgun
<b>Strengths</b>
<ul>
	<li>High Damage Per Second (DPS)</li>
	<li>High Damage Per Shot</li>
</ul>

<b>Weaknesses</b>
<ul>
	<li>Short Range</li>
	<li>High Bullet Spread</li>
	<li>Low Magazine Size</li>
	<li>Low Rate of Fire</li>
</ul>
<p align="center">
  <img src="Gifs/2020-11-05_05-59-42.gif"  width="300" >
</p>

## The Sub Machine Gun (SMG)
<b>Strengths</b>
<ul>
	<li>High Damage Per Second (DPS)</li>
	<li>High Magazine Size</li>
	<li>High Rate of Fire</li>
</ul>

<b>Weaknesses</b>
<ul>
	<li>Moderate Range</li>
	<li>Moderate Bullet Spread</li>
</ul>
<p align="center">
  <img src="Gifs/2020-11-05_06-00-54.gif"  width="300" >
</p>

## The Railgun
<b>Strengths</b>
<ul>
	<li>High Range</li>
	<li>Shots Can Penetrate Enemies</li>
	<li>Low Bullet Spread</li>
</ul>

<b>Weaknesses</b>
<ul>
	<li>Low Rate of Fire</li>
	<li>Low Magazine Size</li>
	<li>Low Damage Per Second (DPS)</li>
<p align="center">
  <img src="Gifs/2020-11-05_06-11-31.gif"  width="500" >
</p>

# Abilities
Additionally, the player has access to several abilities which allow for them to exceed what is normally possible.

## Sliding
Causes the player to slide on the ground while running, making the player's hitbox smaller.
<p align="center">
  <img src="Gifs/2020-11-05_06-15-43.gif"  width="300" >
</p>
## Wall Jumps
Lets the player jump off a series of opposing walls.
<p align="center">
  <img src="Gifs/2020-11-05_06-18-19.gif"  width="300" >
</p>
## Force Field
Creates a spherical ball of energy that surrounds the player, blocking any projectiles that collide with it
<p align="center">
  <img src="Gifs/2020-11-05_06-17-29.gif"  width="300" >
</p>
## Projectile Blast
Emits a strong blast of energy which destroys all nearby projectiles.
<p align="center">
  <img src="Gifs/2020-11-05_06-16-34.gif"  width="300" >
</p>

# Enemies
There are multiple types of enemies the player will encounter, including sentient AI and turrets. Turrets cannot be destroyed.

## X-BOT
X-BOTs are the weakest form of AI, they will patrol the corridors of the facilities. They will use a pistol to shoot a slow projectile towards the player.
<p align="center">
  <img src="Gifs/2020-11-05_06-22-52.gif"  width="300" >
</p>

## Vanguard
Vanguards are stronger, larger, and much more deadly than X-BOTs. These brutes pack an energy infused shotgun which will decimate the player if they get too close.
<p align="center">
  <img src="Gifs/2020-11-05_06-23-50.gif"  width="300" >
</p>

## Projectile Turret
These surface bound machines have the capability to rotate 180 degrees around its central axis, attempting to target the player's location at the time of firing. These weapons may not be dangerous on their own, but a whole group of them in one area will sure get the player moving on their feet.
<p align="center">
  <img src="Gifs/2020-11-05_08-31-26.gif"  width="300" >
</p>

## Homing Projectile Turret
Similar to the Projectile Turret, these weapons can rotate on their axis, however, they have a smaller limit of rotation. They will fire projectiles which will attempt to chase the player, gaining speed the longer they are in the air.
<p align="center">
  <img src="Gifs/2020-11-05_08-30-57.gif"  width="300" >
</p>

## Railgun Turret
These are the types of turrets you always want to be paying attention to. With their enormous barrel, these things can concentrate millions of joules of energy into one centrally focused beam of energy. The turret will always shoot a smaller laser before the blast, indicating to the player that the turret is about fire, allowing for them enough time to react.
<p align="center">
  <img src="Gifs/2020-11-05_08-33-14.gif"  width="300" >
</p>

## Crimson
This is what the entire game leads up to, the final boss fight. Crimson is the toughest enemy in the game by far, having several different attack patterns and abilities which will sure put the player's skills to test. The player will have to use everything in their arsenal if they desire to be victorious.
<div class="row">
	<div class="column">
		<img src="Gifs/2020-11-05_06-43-18.gif"  width="40%" >
	</div>
	<div class="column">
		<img src="Gifs/2020-11-05_06-44-25.gif"  width="40%" >
	</div>
</div>
<br>
<div class="row">
	<div class="column">
		<img src="Gifs/2020-11-05_06-45-00.gif"  width="40%">
	</div>
	<div class="column">
		<img src="Gifs/2020-11-05_06-45-39.gif"  width="40%" >
	</div>
</div>

## How to use the game ##
The program is a unity game. Once launched, click “Play” to be faced with various options. “New game” to start from the first level, “Continue” to start on the level where you last left off, “Level select” to open up a menu of each unlocked level (to unlock a level, one must progress to it through the previous levels). Clicking on “Difficulty” will change the difficulty of the game between Easy, Normal and Hard. 
Easy: 50% Damage taken and 150% Damage done. 
Normal: 100% Damage taken and 100% Damage done. 
Hard: 150% Damage taken and 50% Damage done.
There is also an “Options” button which allows the user to delete all saved data, resetting all level unlocks and forces the user to start from scratch, or adjust the volume.

Once the game is begun, the commander will instruct you of the basics. In the heads-up display, on the bottom left, is the player’s current health. In the bottom middle is a list of the player’s unlocked abilities with their respective key to activate on top. In the bottom right, is the current active weapon’s ammo over max ammo. In the top left, are the weapons the player can use where blacked out weapon icons means the weapon hasn’t been unlocked (found) yet. The weapon icons are paried with a number indicating the key to press to switch to the associated weapon.
## How we modelled objects and entities ##
The turret models, platforms and scenery decorations (crates, columns) are created by Kevin Gao through Blender, kevin.haha@gmail.com. Whilst the weapon models are taken from the asset store. As for the levels, everything was made using Unity’s ProBuilder. For the Player model, it was taken from https://vrcmods.com/item/4352-commando, a website for VRChat avatar models. To match our intended style of the game, we recolored the texture map. To top off the models, every model (gun, enemy, player, ProBuilder objects, etc.) one can find in the game is equipped with one of multiple custom shaders.
## How we handled the graphics pipeline and camera motion ##
--- (Timmy write this part thanks)

As for the camera motion, a simple fixed z coordinate (z dimension is the depth for this game) camera is implemented which essentially chases the player and attempts to focus the player in the center of the camera. To make the game feel more smooth, instead of snapping straight to the player, Spherical interpolation is used to give the camera a “falling behind” feeling while keeping up with the player.
## Description of how the shaders work ##
---
## Evaluation ##
As for the evaluation part of the game, we decided to utilize the <b>"Think Aloud"</b> observation method, this is because we will be able to understand what the user is feeling while playing the game, any signs of stress or confusion can be noted down and analysed to locate the flaws of the software and improve on it. In addition a questionnaire was given to the participants for the querying section of the evaluation. The questionnaire focuses on the friendliness of the user interface and heads-up display, the clarity of the objective of the game, balancing of the game elements (player weapons and level difficulty increase rate), the friendliness of the controls and requests for any bug reports.
The questionnaire can be found here:
https://forms.gle/vT7nAQWQCxUX2znr5

<b>Evaluation subjects</b>
We performed Think Aloud observation method analysis on a total of 9 people, the demographic of these people are in the age range between 19-23, young adults, there were 8 male participants and 1 female participant.
The participants were instructed to load up the game and play the entire game through clicking New Game, the participants were expected to finish every level in consecutive order. Rest breaks were allowed as we have implemented a pause menu and a "Continue" button in the main menu. The participants gameplay along with their voice and the evaluater's voice was recorded as a video using OBS and brought together to be analysed as a group. In addition, the evaluater utilised "paper and pencil" to note down any significant statements or remarks made by the participant as well as any bugs or issues and suggestions found and given by the participant. As the evaluater cannot capture all the information live, the recording proved fruitful in gathering useful information that was skipped over or not noted down.

<b>Feedback</b>
In general the game was well recieved. 33% found the game "Average", while 33% found the game "Fun" and 33% found the game "Very Fun", from this, we can infer that the game was at least somewhat enjoyable for the participants.
<img src="fun.PNG">

At first, the user interface of the game as well as the heads-up display proved to be somewhat poorly designed; evaluation 1, 2 and 3 all suggested that the in game HUD needs to be more indicative of what ability is off cooldown and what gun their using. According to this information, we improved the user interface (which will be explained in the next section) and this is backed up by all of the participants who were evaluated later voting for "Slightly Agree" and "Agree" to the statement: <i>"I found the game interface/UI friendly and easy to understand. (Eg. Icons are very clear in what they do)</i>

<img src="gameinterface.PNG">

Note that the first 3 participants who were exposed to the early user interface voted only for "Not agree nor disgree" and "Disagree".

The game instructions were clear and the query results prove this:

<img src="objective.PNG">

One issue we had was the balacing of the elements of the game, according to the participants' suggestions and comments during Think Aloud evaluation as well as the questionnaire. Level 4 (Second last level) proved to be a great challenge to beat in comparison to the other levels (this issue was addressed and fixed, next section for more information). Another unbalanced element are the weapons the player unlocks. In the Think Aloud observation, the shotgun was only used once every time (that is when it was first picked up) and never used again after. While, the SMG was often the most used weapon in the game. The questionnaire results back this claim up:

<img src="shotgunbuff.PNG">

<img src="smgnerf.PNG">

## Using Images

You can use images/gif by adding them to a folder in your repo:

<p align="center">
  <img src="Gifs/Q1-1.gif"  width="300" >
</p>

To create a gif from a video you can follow this [link](https://ezgif.com/video-to-gif/ezgif-6-55f4b3b086d4.mov).

## Code Snippets 

You can include a code snippet here, but make sure to explain it! 
Do not just copy all your code, only explain the important parts.

```c#
public class firstPersonController : MonoBehaviour
{
    //This function run once when Unity is in Play
     void Start ()
    {
      standMotion();
    }
}
```




