# Assignment_AngelaDrousiotou
2D Snake Game

Video Sample:
Assets used: https://opengameart.org/content/cc0-food-icons

This is not a complete work.
Reader reads the contents of the JSON file and generates them in the inspector. I have not used the reader or the JSOn file any further.

Snake is the player. It contains the snake script where the movement and controls of the player as well as adding body segments when food is consumed.

The food is just an object containing the sprite of a red apple and the script Food that randomly generated food when player consumes one.

Boarders are just the limits where the player can move achieved with colliders.
Score Canvas is the UI for the score on Game Scene and GaveOver is the UI pop up (not working).

Scripts:

MainMenu just loads the menu of the game.
ScoreBoard checks for collision between player and food to increase score by 15 points.
