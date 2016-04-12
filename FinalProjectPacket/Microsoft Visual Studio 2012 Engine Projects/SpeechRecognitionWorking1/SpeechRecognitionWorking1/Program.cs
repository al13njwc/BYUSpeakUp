using System;
using System.IO;
using System.Speech;
using System.Speech.Recognition;
using System.Speech.AudioFormat;
using System.Speech.Synthesis;



namespace ConsoleApplication1
{

    class Program
    {
        static bool completed;

        static void Main(string[] args)

        // Initialize an in-process speech recognition engine.
        {
            using (SpeechRecognitionEngine recognizer =
               new SpeechRecognitionEngine())
            {

                // Create and load a grammar from the MediaMenuGrammar.grxml file.
                string[] myWords = new string[] { "Me", "Kiss", "Fluff", "Yell", "Kind", "Crack", "Hope", "Check", "Lake", "Steep", "Shell", "Bark", "Tooth", "Mouse", "Force", "Fringe", "Flight", "Haunt", "Asked", "Going", "Table", "Giant", "Bully", "Treated", "Spying", "Wiggle", "Shredded", "Picnic", "Decoy", "Slaying", "Scheming", "Happier", "Joyous", "Riotous", "Chow", "Cookie", "Feud", "Eighty", "Host", "Weather", "Crawl", "Stew" }; //Sets the words that it will be listening for
                Choices commands = new Choices(); //Usually the system is sets up the words expected to be commands. Our "commands" will be the 42 words given.
                commands.Add(myWords); //This adds my 42 words to the commands to be recognized (commands being a list of words).
                GrammarBuilder gBuilder = new GrammarBuilder(); //This is setting up the system that will understand the words
                Grammar grammar = new Grammar("C:\\Users\\Taylor\\Desktop\\MediaMenuGrammar.grxml");

                recognizer.LoadGrammarAsync(grammar);
                recognizer.SetInputToWaveFile(@"c:\Users\Taylor\Desktop\AllVoiceSamples\word.wav");



                // Attach event handlers for the results of recognition.
                recognizer.SpeechRecognized +=
                  new EventHandler<SpeechRecognizedEventArgs>(recognizer_SpeechRecognized);
                recognizer.RecognizeCompleted +=
                  new EventHandler<RecognizeCompletedEventArgs>(recognizer_RecognizeCompleted);

                // Perform recognition on the entire file.
                Console.WriteLine("Starting asynchronous recognition...");
                completed = false;
                recognizer.RecognizeAsync();

                // Keeps the console window open.
                while (!completed)
                {
                    //Console.ReadLine(); //This is useful for debugging
                }
                //Console.WriteLine("Done.");
            }
            //Console.WriteLine();
            //Console.WriteLine("Press any key to exit...");
            //Console.ReadKey();

        }

        static void recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            string text = "";

            
                foreach (RecognizedWordUnit wordUnit in e.Result.Words)
                {
                    text = text + wordUnit.Pronunciation + "\n";
                }

                Console.WriteLine(e.Result.Text + "\n" + text);
         




            if (e.Result != null && e.Result.Text != null)
            {
                Console.WriteLine("  Recognized text = " + e.Result.Text);
                File.WriteAllText(@"c:\Users\Taylor\Desktop\CapstoneCode\Output.txt", e.Result.Text);// + Environment.NewLine);
            }
            else
            {
                Console.WriteLine("  Recognized text not available.");
                File.WriteAllText(@"c:\Users\Taylor\Desktop\CapstoneCode\Output.txt", "Not Recognized");// + Environment.NewLine);
            }
        }

        // Handle the RecognizeCompleted event.
        static void recognizer_RecognizeCompleted(object sender, RecognizeCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                Console.WriteLine("  Error encountered, {0}: {1}",
                e.Error.GetType().Name, e.Error.Message);
            }
            if (e.Cancelled)
            {
                Console.WriteLine("  Operation cancelled.");
            }
            if (e.InputStreamEnded)
            {
                Console.WriteLine("  End of stream encountered.");
            }
            completed = true;
        }
    }
}

