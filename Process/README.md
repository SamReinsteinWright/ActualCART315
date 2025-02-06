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
