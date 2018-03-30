# afternite


Assignment #8<br>
Danny Boehm:<br>

* I decided to my Assignment3 submission as a template to add Assignment 8 features.

Completed Parts (1)-(4)
Part (1)
Created a main menu scene with an interface that allows the player to click play. Once clicked the game will start and level will begin. This click loads the ThirdPersonLevel from Assignment 3 (Except modified with new features).

Part (2)
The player can click the escape key ('esc') and access the pause interface. The pause interface disables player movements, freezes the game and gives the player the option to resume, go back to the main menu or quit the game (quit provides a console message).

Part (3)
A yellow checkpoint at the spawning point for the player is actually a NPC Checkpoint which when collided with opens a dialogue box! The dialogue box opens and gives the player information leading up to part 4.

Part (4)
The yellow checkpoint (not the NPC version) when collided with, will bring up a prompt that shows a message "Press F to Interact". When the player is within the collision zone, the interaction is enabled, if the player leaves the collision zone then the interaction is disabled. If the player hits the 'F'  key within the interaction enabled zone, the game will save their progress in case they fall off the zone (hence something happens when pressed). 

----------------------------------------------------------------------

Assignment #6-7<br>
Danny Boehm:<br>

Completed Parts (1)-(4)
Part (1)
- I am the only person in my group but I tried to make two simple objects to have at least more than one object in the scene. I created a chest and a barrel model. 

Part (2)
- As mentioned, I created two different models using Blender, Chest and a Barrel.

Part (3)
- I used Materials to paint both the chest and the barrel.

Part (4)
- Imported the models into the scene from Assignment #5. Models were placed alongside the road, when the scene is loaded, they will be in front of the player near the dirt and can be viewed by walking around. 

* Issues: For some reason when I Smart UV Wrapped and then Baked my models in Blender, they appeared fine; however, when I exported them from Blender in .FBX file format and then created them as Game Objects, they were missing parts of the render. I am not sure why this is because it happened on both objects. Also the Barrell materials for some reason did not cross over into Unity so I had to give it colors within Unity...The chest however, did maintain its Two-Color Palette. 

----------------------------------------------------------------------

Assignment #5<br>
Danny Boehm:<br>

Completed the Assignment 5 (Parts 1-4)
Features Implemented into NPC AI
- Added NPC (BANDIT) Behavior.
- Added a Dialogue Box with Multiple Interaction Options. 
- Added collision/obstacle avoidance to the NPC character.
- Added A* Pathing to (3) Different Goal Points (Dragon, Condor, Chicken) based off the NavMeshAgent.
- Created Scripts to handle the character controller of the NPC
  - Walkto, TextBoxManager, ActivateTextAtLine, TextImporter.
- Created the 'chase' sript that causes the NPC to follow the player the player once in range. NPC always targets and rotates to face the target when nearby. Deactivated to showcase the A* Pathing.
- Created the 'wander' script that causes the NPC to randomly wanter around multiple waypoint locations to simulate a wandering movement through the terrain. Deactivated to showcase the A* Pathing.


----------------------------------------------------------------------


Assignment #3<br>
Danny Boehm:<br>
Completed Part (1) and Part (2) of Assignment 3 as seperate scenes.
For Part (3) I updated the ThirdPerson Scene. Updates Included:
- Implemented collision control for character interactions with objects.
  -  Character cannot go up certain steep hills due to collision at a certain point. Player is able to jump onto a steep incline and walk up for a little bit before crouching and then being blocked from going higher.
- Implemented downhill movement on steep terrain. Player will now slide down a steep incline if motion is not applied to the characters movement. 
- Added camera collision detection around objects. 
- Created a Respawn Trigger Script
  - Triggers include checkpoint and Finish Goal object where the player will respawn if jumped onto the checkpoint. Also if the player jumps onto the finish line goal object, character will celebrate for completing the course.

----------------------------------------------------------------------


Assignment #2<br>
Danny Boehm (5) Edits to Shooter Project<br><br>
(1) Fixed ZombieBear Pathing: ZombieBear Enemy Spawned without movement. <br>
Fixed pathing which allowed ZombieBear to spawn and move towards the player.<br>
(2)Fixed Hellephant Pathing : Enemy Elephant was not locating the player correctly and EnemyMovement was corrected. <br>
Elephant now tracks player down and attempts to trigger Player Death.<br>
(3) Corrected Gun Barrel End Width: Minimized the width of GunBarell Light to .1 instead of .5<br>
(4) Updated Enemy Spawn Points : Adjust the Spawning locations of ZomBunny, Zombear and Hellephant to match their map locations.<br>
(5) Adjusted GameOverOverlay Color: Changed the overlay color for the GameOver screen to #F45A5A00<br>

----------------------------------------------------------------------
Assignment #1 <br>
Hello, This is Danny. I am making an edit to the README ^_^<br>
<br><br>
Nicole has also made an edit to the README<br>
<br><br>
