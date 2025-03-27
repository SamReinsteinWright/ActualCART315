# Process Journal

## Tiny Game Process | 01.23.25
So this will be voice recorded and then transcribe by my phone so I can just get all the ideas out there. I started 
out by checking out the different software’s or engine and also looked at the example games that were listed in the 
prompt. I found that they were extremely complex, highly polished games, one even being a really engaging puzzle 
game. I decided to make a small game based around the idea of waiting in a line because I thought that was mundane 
and funny and inane first the first parts were creating these sprites and the tiles which was somewhat annoying 
because in bitsy I didn’t know how to refresh the page once it had been broken so I tried my best decided on a 2.5 
D game where you are the last in line and you have to help everyone else in line solve their issues before you can 
be first in line. The next steps were coming up with a little stories that each person would have and how to 
connect them with each other such that I would all have this in one room after deciding each character is 
relationship with each other quest wise. I then started trying to implement my ideas of how the player was to go  
about completing these quests it took me a while before I found out how to do an F then statement and then even 
longer how to do a a true or false variable I ended up just using items and giving them to the player and checking 
whether or not the player had the item or not and that’s the small game

Playtest in class: no one understood that people get new dialogue after certain events. No one liked reading.

 ![this is a photo](link to photo)
 
## Dropper game thing
Not a lot to report this week I was curious about bouncing materials, as well as trying to keep the balls up. I was 
also interested in kind of learning for myself how to create objects and use them properly.

## PawngToSoccer
I am looking to create pong into more of a soccer game, where two players must face each other while having access to all two dimensions and interact with a ball by either ramming it or having a button to kick the ball in the direction they are moving. 

The first step is to add movement script for the left and right direction as opposed to up and down for the paddles

After adding the movement script, I had to adjust the parameters of the movement the same way that we adjusted up and down, but for left and right

Next step is to tweak the ball script to make it so that it does not constantly speed up and that it slows down while not in contact with a paddle emulating a ball rolling on the ground

This is turning out to be more difficult than expected, as there is a no way to ascertain the other objects Current momentum to then apply that force back to the ball if I’ve attempted to slow it down using linear damping so there’s no way to really hit the ball

The only thing I can think of is to try and check if one of the keys is being pressed down when in contact with a paddle and then apply a force in that keys direction

I found a way to do somewhat directional move Finding the position of both the ball and the paddle it is hitting during collision and then adding a force away from the paddle so it does bounce properly

Last step is to find a way for the paddles to not start in the middle like they’ve been for some reason

I ran out of time to fix this bug

## Struggle week (the one where we were supposed to do brick break)
I wanted to work more on the artistic aspect this time around as i enjoy animating. So i drew up a character that would sit on the side of the screen making exclamations as you broke the bricks. Unfortunately before i could download the template (since I missed the class where it was introduced) bell's internet server decided to crash and locked me out of accessing the internat at all until today. I have the drawn chaarcter if you would like to see him but nothing else was able to get done this week.
## making a faudian game
By attempting to bring the brick breaker into Unity and really failing at that because I missed the class where it was taught how to do all that stuff, so I missed how to import it. 

So I decided to instead just modify a previous project, which I chose the Pong project that we did. 

I want to turn it into a platformer where you can jump move from side to side, all physics based as well, using force as opposed to just predetermined values as well as add a dash or maybe a type of grappling hook mechanic that the grappling hook would be very hard. 

I think it'd be fun. I added in the movement mechanics by bringing over some of the code from the paddle script and giving adding force based on what button is pressed. 

I also added a boolean, checking whether or not the ball has entered contact or exited contact with a tile or a sprite called Brick, because I forgot to learn how to make a a tag myself. 

So I used the brick tag that was already in the game to indicate floor or ground. 

So it has the grounded boolean. You can move and jump. If you're grounded in the air, you can't move, which kind of turns it into almost like a. 

Like a rage game, kind of like a faudian game. The rest of my time was spent making level geometry. I had a couple problems implementing the movement because i chose the player character to be based on the pong ball and so it was rolling around when it moved and the transform up function was relative to the object's orientation.

## march 13th 
While last week was all about conceptualizing our game coming up with ideas through drawing and talking this week, we wrote down the ideas and broke them up into actionable steps for us to work on today. Many fundamental gameplay concepts were changed from last week to this one. We reworked how the sheep moved to generate a more engaging gameplay experience.

Art
--Character
----Image
----Animation
--Sheep
----Image
----Animation
--Terrain 
----Animated?
--Enemy 
----Image
----Animation
--Points of interest
----Sprites
----Animation
Gameplay
--Sheep (Your health)
----Sheep movement
------Random sheep: idle movement in map 
------Follow player’s cursor when owned/claimed
------More sheep in herd makes them all move slower

----Collection	
------Sheep don't follow directly
------Collect sheep: Player shouts
--Player 
----Player movement 
------WASD for Shepherd movement (player) 
------8 directional movement or player facing
------Player shouts with E, and sheep move quicker but away from the player 
------Space bar for shooting shotgun
--------Shotgun mechanics 
----------Shoot in the last direction player was looking at
----------Projectile
------------Shoots 6 pellets
------------Does not normally pass through enemies
--Sheep dog (Player 2 in the future)
----Moves with arrow keys
--Enemies 
----Burrower
------Burrows underground to become invulnerable and deal no damage to then choose a spot to re-emerge.
------Upon re emerging an area around the enemy erupts dealing killing the sheep
----Regular enemy
------Heads towards sheep
------Kills sheep
--Swarm
----Many small enemies
----Bullets pass through

Structure
--Multiple pages
----Game start
------Title screen
------Instructions 
----Gameplay 
----Game over 
Camera 
--Follow player

 ## Actually making a game
 This week was a big one.First off I imported the pong template because I had already created a movement script in there for the main character. I then got distracted and made the background image for the start menu of the game. (here is the link to the image in my drive as I forgot how to insert images: https://drive.google.com/file/d/1kzoeCdu3UHMH1B7Qn9Cn1VNc4MJEDN7Z/view?usp=sharing )I then decided to add in the Sheep. I had forgotten that we had decided to implement the Sheep following Behavior to be to move towards the mouse so I instead implemented a sheep behavior in which they check for collisions in their surroundings if the entity that is entered their View is another sheep they then find out that sheep's movement Direction and speed and add a part of those  values to their own direction and speed which in theory would generate flocking Behavior.  I also added a script that forced the Sheep to move in a random Direction every 5  Seconds this is a temporary fix because I could not test the Sheep running away from the mouse clicks at that point.  I will change it from every 5 Seconds to be every 5 to 10 seconds when the Sheep has been still for those whole 5 seconds. 

 I attempted to implement this Behavior and screwed up some of the numbers making the Sheep repulse each other instead of tend towards each other here is a drive link to a video of that happening: https://drive.google.com/file/d/1wWO5veX0LXgAZ_8NM4h5dGEbV9uBRvZc/view?usp=sharing 

I finally got it working the way I wanted to with a few exceptions that I could not figure out how to implement a Max velocity for the Sheep such that they wouldn't go randomly flying in a Direction the following two links are videos of this working one of them has commentary of US during the creation process. 
https://drive.google.com/file/d/1vizUScoBPY-gnKhiHUgta7jym1v1yAKV/view?usp=sharing 

https://drive.google.com/file/d/11AunPnHIca51EWG2EQu3A7AOhWO88d1-/view?usp=sharing 


