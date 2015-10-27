import time
from pygame import mixer
from pygame.mixer import music

mixer.init(frequency=16000)
 
mixer.init()
music.load('word1.mp3')
 
music.play()
time.sleep(10)
 
music.stop()
mixer.quit()