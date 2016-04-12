#################################################################################
#                             SETUP INSTRUCTIONS                                #
#                                                                               #
# There are two folders that need to be set up. There needs to be on folder     #
# which I called "CapstoneCode" with files including:                           #
# SpeechRecognitionWorking1.exe, FinalOutput.csv, InputOutputScript.py,         #
# FinalOutput.txt, and Output.txt. The second folder is outside this one and    #
# which I called "AllVoiceSamples" which includes: Input.txt and all voice      #
# samples that you want to test. You might be able to change how the folders    #
# are set up if you want to, but this is how I had it set up when this worked.  #
#################################################################################

import os
import shutil
import time
import subprocess
import signal
from subprocess import call



#print "Input test detail sentence: "
#userInput = raw_input() #Type input on who is testing the file and what is special about it (will be header on .csv file)
#text_file = open("/home/taylor/Desktop/CapstoneCode/Output.txt", "w")
#text_file.write(userInput + "\n\n")
#text_file.close()

for j in os.listdir(os.path.abspath('C:\Users\Taylor\Downloads')):
#for i in os.listdir(os.getcwd()): # Goes through the folder. The current file is put in variable "i"
    print "got directory"
    if j.endswith(".wav"):
        #print "The output word is: " + j
        #os.rename(j, "C:\Users\Taylor\Desktop\AllVoiceSamples\word.wav") 
        shutil.move(os.path.join('C:\Users\Taylor\Downloads', j), os.path.join("C:\Users\Taylor\Desktop\AllVoiceSamples", "word.wav"))

print "arrays created"

for i in os.listdir(os.path.abspath('C:\Users\Taylor\Desktop\AllVoiceSamples')):
#for i in os.listdir(os.getcwd()): # Goes through the folder. The current file is put in variable "i"
    print "got directory"
    if i.endswith(".wav"): #Looks for .wav file types. m4a files don't work with Pygame
        #print "found a .wav file with output: " + i
        text_file = open('C:\Users\Taylor\Desktop\AllVoiceSamples\Input.txt', "w")
        text_file.write(i)
        text_file.close()

        p = subprocess.Popen(r"C:\Users\Taylor\Desktop\CapstoneCode\SpeechRecognitionWorking1.exe") # This starts the executable (compiled) code for the C# program
        #os.system("python -m speech_recognition")
        time.sleep(2)
        #p.kill() # Kills the c# process since I wasn't able to open the next file or get correct output if I didn't
        print "The process is over"
