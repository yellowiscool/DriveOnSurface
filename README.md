DriveOnSurface
==============

MarioKart like with Microsoft PixelSense, HTML5 Devices using Node.js, Socket.Io, Box2DWeb and ravings rabbits.

## Requirements

 * A web browser
 * A computer able to run a Node.js server
 * A Microsoft Pixel Sense device
 	* The project is developped with the Samsung SUR40
 	* A great device if you live in a cave without lights

## Architecture

 * A server written in Javascript with node.js
 	* Game logic and more
 * A Pixel Sense (surface) client written in C# and XNA
 	* The main view
 * A HTML5 client using SenchaTouch
 	* For gamer controls on PC and mobiles
 * A native Android client
 	* For gamer controls in Android (if you prefer compared to the HTML5 client)
 * A track editor and debug view written in HTML5

The communications betweens all these elements are done with a REST API and Socket.IO events.

## How to install

### On the server

You have to install Node.js and NPM first.
You could take a look at the settings.js file, but it should be working out of box.

```shell
# Install the server dependencies
npm install

# Optionnal (if you want the editor view)
npm install canvas

# Start the the server
node server.js
```

### On the table

You have to edit the config.txt if you want to change the server location setting (localhost by default).

Start the executable, and enjoy.

### On the gamers clients

Visit the server, and select your favorite client. If you use the PhoneGap or Android client, you have to set the server address.


##### Tags replacement

If you need to change the tags used, you only have to edit server's settings.json to associate new tag values to the traps.


## How to play

 * Start the server
 * Start the pixel sense client
 * Select the track and wait for the players
 * Now, players can start the app and choose a pseudo (gamer key, so don't use the same pseudo)
 * and a kart color…
 * Give the tags to the players according to their colors
 * Start the game (and wait to the green lights)
 * Players can control their karts using directions keys or orientation sensors
 * If a player obtain a bonus, he can put the correct tag on the table where he wants to put the trap
 
 _If you want to play a other track, you have to restart all the process (restart the server, the pixel sense client and the gamers clients…)._

## Licence

InspecteurDeryque is released under the [CeCILL-B V1 licence](http://www.cecill.info/index.en.html).
