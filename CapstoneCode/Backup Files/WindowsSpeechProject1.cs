using System;
using System.IO;
using System.Speech;
using System.Speech.Recognition;
using System.Speech.AudioFormat;

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

        // Create and load a grammar.
          string[] myWords = new string[] { "Me", "Kiss", "Fluff", "Yell", "Kind", "Crack", "Hope", "Check", "Lake", "Steep", "Shell", "Bark", "Tooth", "Mouse", "Force", "Fringe", "Flight", "Haunt", "Asked", "Going", "Table", "Giant", "Bully", "Treated", "Spying", "Wiggle", "Shredded", "Picnic", "Decoy", "Slaying", "Scheming", "Happier", "Joyous", "Riotous", "Chow", "Cookie", "Feud", "Eighty", "Host", "Weather", "Crawl", "Stew" }; //Sets the words that it will be listening for
        Choices commands = new Choices(); //Usually the system is sets up the words expected to be commands. Our "commands" will be the 42 words given.
        commands.Add(myWords); //This adds my 42 words to the commands to be recognized (commands being a list of words).
        GrammarBuilder gBuilder = new GrammarBuilder(); //This is setting up the system that will understand the words
        gBuilder.Append(commands);
        Grammar grammar = new Grammar(gBuilder);

        recognizer.LoadGrammarAsync(grammar);
        recognizer.SetInputToDefaultAudioDevice();
            
          
          
          //Grammar dictation = new DictationGrammar();
        //dictation.Name = "Dictation Grammar";

       // recognizer.LoadGrammar(dictation);


        StreamReader sr = new StreamReader(@"c:\Users\Taylor\Desktop\AllVoiceSamples\Input.txt");
        // Read the input file to a string
        String line = sr.ReadToEnd();
        

        // Configure the input to the recognizer.
        recognizer.SetInputToWaveFile(@"c:\Users\Taylor\Desktop\AllVoiceSamples\" + line);

        // Attach event handlers for the results of recognition.
        recognizer.SpeechRecognized += 
          new EventHandler<SpeechRecognizedEventArgs>(recognizer_SpeechRecognized);
        recognizer.RecognizeCompleted += 
          new EventHandler<RecognizeCompletedEventArgs>(recognizer_RecognizeCompleted);

        // Perform recognition on the entire file.
        Console.WriteLine("Starting asynchronous recognition...");
        completed = false;
        recognizer.RecognizeAsync();

        // Keep the console window open.
        while (!completed)
        {
          Console.ReadLine();
        }
        Console.WriteLine("Done.");
      }

      Console.WriteLine();
      Console.WriteLine("Press any key to exit...");
      Console.ReadKey();
    }

    // Handle the SpeechRecognized event.
    static void recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
    {
      if (e.Result != null && e.Result.Text != null)
      {
        Console.WriteLine("  Recognized text =  {0}", e.Result.Text);
        File.AppendAllText(@"c:\Users\Taylor\Desktop\AllVoiceSamples\Output.txt", e.Result.Text + Environment.NewLine);
        //StreamWriter sw = File.AppendText(@"c:\Users\Taylor\Desktop\AllVoiceSamples\Output.txt");
        //sw.WriteLine(e.Result.Text + ",\n");//The other code will add the headphone type, the name, etc.
      }
      else
      {
        Console.WriteLine("  Recognized text not available.");
        File.AppendAllText(@"c:\Users\Taylor\Desktop\AllVoiceSamples\Output.txt", "Not Recognized" + Environment.NewLine);
        //StreamWriter sw = File.AppendText(@"c:\Users\Taylor\Desktop\AllVoiceSamples\Output.txt");
        //sw.WriteLine("Not Recognized\n");
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
