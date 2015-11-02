import os
import time
from pygame import mixer #I am using Pygame for this, though it would be nice to make a few different files to play from the built in player
#Pygame can be downloaded from: http://www.pygame.org/download.shtml
from pygame.mixer import music

for i in os.listdir(os.getcwd()): #Goes through the folder. The current file is put in variable "i"
    if i.endswith(".mp4"): #Looks for different file types. m4a files don't work with Pygame
        mixer.init(frequency=16000) #Determines how high pitch the voice is played back. 16000 is normal
        mixer.init() 
        music.load(i) #Loads the file that it is currently on ("i") to play
        music.play() #Plays the file
        time.sleep(10) #Delays the player to stop after X seconds
        music.stop() #stops the music
        mixer.quit() #Quits Pygame
        continue
    else:
        continue
