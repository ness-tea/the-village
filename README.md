# The Village 1.0
(In Progress) A 2D puzzle-platform-adventure game developed in Unity and C#. Looking into implementing AI for in-game opponents.

To open project:
```
  - Download repo onto your local computer.
  - Open the directory as a project in Unity.
  - Audio excluded due to large size.
```

What's been implemented + Potential ideas:
  - [x] **Checkpoint 1:** Player talks to all NPC's.
  - [X] **Checkpoint 2:** Player receives quest from Laris.
  - [x] **Checkpoint 3:** Player achieves quest and returns to Laris.
  - [x] **Checkpoint 4:** Player receives quest from Donyke.
  - [x] **Checkpoint 5:** Player explores **Dark Abyss** underground.
  - [ ] **Checkpoint 6:** Player returns to ceremonial gathering.
  - [ ] **Checkpoint 7:** Different ways for Player to distract village.
  - [ ] **Checkpoint 8:** The Escape Plan.
  - [ ] **In-game AI Monsters:**
  - [ ] **Health Status Bar**
  - [ ] **Currency System**
  
## 1 Overview:

This document will describe the design decisions that have been made in the development
of **The Village**. It will justify the choices in design regarding the game world, creative and
expressive play, character design, narrative structure, interface design, gameplay, and core
mechanics; it details how these choices ultimately affect the overall game.

### 1.1 Assets
  - Player & Player Movement Scripts - Asset Store: Standard Assets for Unity 4.6
  - Village Houses - Asset Store: Arabian & French buildings
  - Terrain - unity Asset Store (can't find exact link)
  - NPC's - Asset Store: Mighty Heroes (Rogue) 2D Fantasy Characters Pack
  - Trees - Free Low Poly Pack
  - Fence - clipart from Google Images
  - Wooden sign - clipart from Google Images
  - Berry bush - clipart from Google Images
  - Secret notes - clipart from Google Images

## 2 Game Setting & World

### 2.1 Setting 

**The Village** in a mysterious, remote, and dark little town situated in the middle of nowhere. 
The exact location of the village is unknown to the player. The general atmosphere of **The Village**'s 
game setting is meant to be unsettling and mysterious, evoking feelings of uneasiness and 
puzzlement in the player. With the little information provided on the village's background 
and the dark, muted colour palette of the village's environment, the game setting is meant 
to ignite a sense of curiosity. It encourages the player to be intrigued enough to continue 
playing the game and uncovering the mysteries that are scattered around its setting.

### 2.2 World

The game world of **The Village** entails many strange superstitions and beliefs that the
villagers follow; how every villager keeps a secret note with a wish on them under the belief
that it will one day be fulfilled, how the fireflies denote all of the secret note wishes that have
been fulfilled, how the Dark Abyss (the area surrounding the village) is seen as a danger
zone, and how the villagers discourage anyone from venturing beyond the village outskirts.
The oddness of the villagers and the beliefs that they sustain in the game world add to the
uneasiness and confusion that is intended to be evoked in the player. The superstitions are
meant to be questioned and poked at by the player, so that it keeps them engaged with the
game's story and sequence.


## 3 Creative & Expressive Play

### 3.1 Rationale for No Player Creativity or Expression

Although **The Village** does not heavily encompass the player with creative or expressive
play, there are a few elements that allow the player some creative thinking in the process.
The game doesn't give the player the ability to customize their avator or express their
character in some form because it is intended for the player to be placed in the game with no
knowledge of what the game entails. Allowing the player to express themselves through their
avatar or customize the game elements in any way will take away from the mysterious and
puzzling atmosphere of the game. The player isn't even expected to know anything about
the character that they're playing; the game is designed so that the player will also feel
encouraged to unravel more information on who their character is and what their purpose
is.

## 3.2 Minimal Creativity 

Nevertheless, the game offers some creative thinking for the player at a future checkpoint,
when the player has to figure out some way to distract all the villagers and escape the village.
At this point, the game will give the player several directions to take, meaning that there
are multiple ways that the player could create a distraction. The burden is on the player to
creatively improvise and choose a tactic to carry out this mission.

### 4 Character Design

The characters in **The Village** consist of the player's character and the NPC's within
the village. The player will get the chance to learn more about their character's personality
and motifs, as well as those of the NPC's, through the exchange of dialogue between the
characters. As the player roams through the village and interacts with different villagers,
they'll learn about the villagers' perspectives and attitudes towards the village. Certain traits
that the player may pick up on are the villagers' stubbornness, narrow-mindedness, and their
hostility towards those who go against their superstitiions. The villagers' personalities are
designed to make the player feel out of place and as if they don't belong. Through these
measures, the player is pushed to question why the villagers behave this way, and why they're
so strong on their beliefs.

Other villagers will interact with the player in ways that will make them question the
secrets that the village is hiding. While some villagers do whatever it takes to follow the
village ways, other villagers will behave in ways that rebel against the village's system, and
secretively confess these to the player. This will give the player a growing sense of suspicion
for the village, all of which will lead the player to the climatic reveal of the village at some
point down the game's progress.

## 5 Interface Design 

**The Village** does not encompass many complex user controls. In the 2D nature of the
game, the player has controls for moving left and right (the left and right arrow keys), as
well as jumping (space bar). The game doesn't require the user to move in the up and down
directions as the camera isn't aimed from a topview or bird's eye, but rather from a profile
view. Players will be required to move through the village and the Dark Abyss, as well as
jump to higher or lower platforms. Player's won't need to point-and-click to interact with
NPC's; interaction with NPC's will be activated whenever the player moves close enough to
them. As the player progresses through the game, the dialogue box will occasionally pop up
and express the character's thoughts, which will work to provide hints and guide the player
closer to achieving each checkpoint.

## 6 Narrative Structure

**The Village** is a game that is hugely driven by its narration. The player essentially
narrates the story through uncovering the different checkpoints in the game. Nothing is
initially known about the village's backstory, thus the player works to unravel how the story
is told by reaching each checkpoint in sequential order.
When the game begins, the player is placed near the village outskirts, and is first in-
troduced to their character's secret note through the dialogue box. The narration for the
game is entirely communicated to the player through the dialogue box at the bottom of the
screen. Afterwards, the player is prompted to explore the village. At this point, the player
can freely roam around the village and interact with the different NPC's, each of which are
villagers that provide the player with vague information about the village's history that the
player will need to piece together on their own. This serves as an introductory to the village's
backstory for the player.
Later on, the player will be requested by selected NPC's to venture beyond the village
into the Dark Abyss to carry out small quests. From these quests, the player will be taken
on the insidious journey to unravelling what exactly the village is hiding and its dark secrets.

## 7 Gameplay

Throughout **The Village**, there will be checkpoints that the player will need to reach.
Checkpoints will be marked or defined at certain puzzles/clues throughout the game. The
game is a predetermined story - meaning that the game will be played in a linear fashion,
and the checkpoints will need to be reached in sequential order. In other words, the game
will be designed so that it won't be possible for the player to achieve a certain checkpoint
unless all checkpoints that precede it have been achieved. Whenever a player surpasses or
discovers that checkpointed clue, they will achieve a checkpoint, and be able to move on to
the next checkpoint. These checkpoints can be in the form of interactions with an NPC, or
an event that occurs with the player's character.

### 7.1 Checkpoints

An outline of the checkpoints thus far in the game:

1. Player talks to the NPC villagers and gains insight on the village backstory.
2. Player is requested by Laris (a villager) to gather berries from the berry farm in the
Dark Abyss (beyond the village outskirts).
3. Player witnesses questionable scene.
4. Player returns to village and gives berries to Laris.
5. Player speaks with Donyke and is requested to venture beyond the village outskirts
again.
6. Player stumbles upon pile of secret notes and discovers that village may have insidious
agenda.
These checkpoints will take approximately 5 minutes for the player to solve.

## 8 Core Mechanics

The core mechanics for **The Village** for the most part imitates the behaviour on earth.
There is a central force of gravity that acts on all objects, thus the player is only able to
jump to heights of certain limits. There are not many other required core mechanics for the
player's movement as the game is not heavily focused on the 
exibility of the character's actions, but the narrative puzzle that the player is out to solve.
Another core mechanic of the game comes from the player's interactions with the NPC
villagers. Whenever the player is within a certain measurable range from a villager, the
interactive dialogue is activated and a conversation is initiated with the villager. This mech-
anism was chosen over the standard point-and-click interaction with the mouse because it
gives the player more of the impression that the villager strikes a conversation with the
player as opposed to the villager striking a conversation with the villager.
