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
import time
import subprocess
import signal
from subprocess import call

print "arrays created"

text_file = open("Output.txt", "w")
text_file.write("")
text_file.close()


for i in os.listdir(os.path.abspath('C:\Users\Taylor\Desktop\AllVoiceSamples')):
#for i in os.listdir(os.getcwd()): # Goes through the folder. The current file is put in variable "i"
    print "got directory"
    if i.endswith(".wav"): #Looks for .wav file types. m4a files don't work with Pygame
        print "found a .wav file with output: " + i
        text_file = open("C:\Users\Taylor\Desktop\AllVoiceSamples\Input.txt", "w")
        text_file.write(i)
        text_file.close()

        text_file = open("Output.txt", "a") # The "a" stands for append
        text_file.write(i + ",")
        text_file.close()

        p = subprocess.Popen(r"C:\Users\Taylor\Desktop\CapstoneCode\SpeechRecognitionWorking1.exe") # This starts the executable (compiled) code for the C# program
        time.sleep(2)
        p.kill() # Kills the c# process since I wasn't able to open the next file or get correct output if I didn't
        print "The process is over"
        time.sleep(2)
        text_file = open("Output.txt", "a") # The "a" stands for append (it appends to the Output.txt file whatever is written to it)
        text_file.write("\n") # Writes to the Output.txt file
        text_file.close()

        f1 = open('Output.txt', 'r') # These (8) lines are to replace the "_" with a comma and removes the ".wav" ending
        f2 = open('FinalOutput.txt', 'w') # The "w" writes to the file anew (doesn't append, but replaces if there is text already there)
        for line in f1:
            line = line.replace('_', ',')
            line = line.replace('.wav', '')
            f2.write(line)
        f1.close()
        f2.close()


filename = "FinalOutput.csv"
try:
    os.remove(filename) # Removes the file with this name if it exists in the folder
except OSError:
    pass

os.rename("FinalOutput.txt", "FinalOutput.csv") # Converts the FinalOutput.txt file into a .csv file
time.sleep(2)
open("FinalOutput.txt", 'w') # Creates a new FinalOutput.txt file
