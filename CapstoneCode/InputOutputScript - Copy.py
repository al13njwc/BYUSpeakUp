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


print "Input test detail sentence: "
userInput = raw_input() #Type input on who is testing the file and what is special about it (will be header on .csv file)
text_file = open("Output.txt", "w")
text_file.write(userInput + "\n\n")
text_file.close()

#Added for Google Speech key limitations ***********************************
count = 0 #2356 wav files total
text_file = open("Keys.txt", "w")
text_file.write("AIzaSyAP7A5nYl9R7h1lJdOdIV_rNTWqnu2Pmys")
text_file.close()
#End of what added for Google Speech *****************************************


print "arrays created"

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

        #Added for Google Speech key limitations ***********************************
        if count > 299 and count < 600:
            text_file = open("Keys.txt", "w")
            text_file.write("AIzaSyCEBO8rLUQ88l6kPnQuyEW0F-YwFw67R3c")
            text_file.close()
        if count > 599 and count < 900:
            text_file = open("Keys.txt", "w")
            text_file.write("AIzaSyAyg4xDd_rP83Yt8IsQ5kqU--maAU8Xi2Q")
            text_file.close()
        if count > 899 and count < 1200:
            text_file = open("Keys.txt", "w")
            text_file.write("AIzaSyDKU9qreE-eUVz2Qr0J0z-Bbfx_BeY426w")
            text_file.close()
        if count > 1199 and count < 1500:
            text_file = open("Keys.txt", "w")
            text_file.write("AIzaSyBa0vWeb0ASeiluhFdw-fRaxhiPWnL-N1I")
            text_file.close()
        if count > 1499 and count < 1800:
            text_file = open("Keys.txt", "w")
            text_file.write("AIzaSyAPlQJEjxuQ8lPuGlhdeGHCchDxAKzDO90")
            text_file.close()
        if count > 1799 and count < 2100:
            text_file = open("Keys.txt", "w")
            text_file.write("AIzaSyBo1MLygzmzaZkPPPX0CzDZF22K05ZyuQ8")
            text_file.close()
        if count > 2099 and count < 2400:
            text_file = open("Keys.txt", "w")
            text_file.write("AIzaSyBb8XUH9aPEO1Q9GAoHf9rREdUlizXQ_Hk")
            text_file.close()\
        #End of what added for Google Speech *****************************************

        count += 1

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
