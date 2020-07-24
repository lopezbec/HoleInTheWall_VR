# Hole In The Wall: VR + Kinect
### Thomas Stranick & Prof. Christian Lopez
[sites.lafayette.edu/lopezbec](https://sites.lafayette.edu/lopezbec)

---

This gamification application aims to integrate the body tracking of the Kinect with the visual enhancement from the Oculus headset. This is in the medium of a full body movement game called Hole in the Wall where the user must contort their body to match the shapes cut out from the wall moving towards them. It also will help observe whether VR or other game elements improve a persons preformance when it comes to completing such a task.

## Progress Videos
- First Integration of Oculus Hardware: https://youtu.be/OrrPDqjEcq0  

  The Unity project needed to be set up for VR development rather than having the game being presented on the monitor. The OVRPlayerController was also added so that the headset could have a presence within the game world. This allowed for manipulaton of the headset positioning and controller inputs. This early model pressed the interactables of the game with the hand controller, however later turned out that they are detrimental to the Kinect tracking. Also a system was put in place to give the user a random name as there was not built in keyboard for entering one.
  
- Demonstration of Leaderboard after game has finished: https://youtu.be/-POtxZyMrho  

  Looking to add game elements to effect people's perfomance the leaderboard was added. The score the player achieves at the end of the game is taken and put into the list of "previous players" to be shown on the leaderboard. To begin there is a set list of random names on the leaderboard, however if the game continues being played it will populate with real players. The random assigned names helps to not create a direct competitive link between friends and such playing the game, however an anonymous way to possibly motivate yourself to do better and improve.
  
  
- Example of Achievement being displayed after completion: https://youtu.be/bgYfcYglNAo  

  Much like the leaderboard, the achievement system intends to be another game element that effects players performance when playing the game. These achievements will be things like passing through a number of obstacles in a row or only touching the wall slightly when passing through. When the game detects that an achievement has been achieved it will display a notification on the top left. The achievement board to view achievements is still a work in progress in terms of having an indicator as to when you have completed the achievement, however does show all of the achievements the player can obtain.
  
- First Integration of Kinect with Oculus Hardware: https://youtu.be/BGRf_9yo7wg  

  This was the first time using the Kinect with the Oculus headset. The main issues that needed to be addresed were the headset not always spawning directly in the avatar when the Kinect motion tracking kicked in. This was due to the oculus having its own position tracking and not being possible to place it exactly where it is wanted in the game world.
  
- Using hand colliders to press buttons: https://youtu.be/ZMX9TsXrXY8  

  In order to make it more immersive and interactable the controllers were taken away and the Kinect motion tracking is all thats needed in order to press buttons and such. Colliders were added to the hands as well as the buttons that allow for triggering when they touch each other. Much like pressing a button in real life the user will now have to reach out to press the button in game rather than pointing at it with the controller. This also allowed for easier tracking of the hands when not holding controllers.

- Spawning the Oculus headset view inside the Avatar head: https://youtu.be/dvUUkWfhSsc  

  In previous videos using the Kinect and Oculus they were never lined up. In order to fix this, the difference between the starting headset and avatar positioning and rotation was taken. The headset then moved to the corresponding position utilizing that calculation. This allows for a much more immersive experinece when the body in the VR world more closely mimics the one you have in the real world. If it is out of sync it breaks immersion.  

-First UI Improvements and base Voice Recognition: https://www.youtube.com/watch?v=d25_yzMvHbI

The UI needed to be updated to reflect the current project and make it look a little nicer. The voice recognition system was also put in place to allow users to spell their name by saying letters into the microphone. This will be looked at further in having the game take full names or typing the name out on a keyboard to make it work better and easier.

## References
 Lopez, C. E., and Tucker, C. S., “The effects of player type on performance: A gamification case study,” Computers in Human Behavior (2019) 91, 333-345 ([doi:10.1016/j.chb.2018.10.005](https://www.sciencedirect.com/science/article/pii/S0747563218304898?via%3Dihub))
 
Lopez, C. E., and Tucker, C. S., “A quantitative method for evaluating the complexity of implementing and performing game features in physically-interactive gamified applications,” Computers in Human Behavior (2017), 71, 42-58 ([doi: 10.1016/j.chb.2017.01.036](https://www.sciencedirect.com/science/article/pii/S0747563217300481?via%3Dihub) )

