import subprocess
import time


proc = subprocess.Popen('cmd.exe', stdin = subprocess.PIPE, stdout = subprocess.PIPE)
stdout, stderr = proc.communicate('dir c:\\')
stdout 'ping www.google.com'
time.sleep(10) #Delays the player to stop after X seconds
