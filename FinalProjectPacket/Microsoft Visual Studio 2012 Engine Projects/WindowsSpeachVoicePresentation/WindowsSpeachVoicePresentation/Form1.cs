using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;

namespace WindowsSpeachVoicePresentation
{
    public partial class Form1 : Form
    {
        SpeechRecognitionEngine recEngine = new SpeechRecognitionEngine(); //creates an instance of the engine for Windows Speech Recognition
        string[] myWords = new string[] { "me", "kiss", "fluff", "yell", "kind", "crack", "hope", "check", "lake", "steep", "shell", "bark", "tooth", "mouse", "force", "fringe", "flight", "haunt", "asked", "going", "table", "giant", "bully", "treated", "spying", "wiggle", "shredded", "picnic", "decoy", "slaying", "scheming", "happier", "joyous", "riotous", "chow", "cookie", "feud", "eighty", "host", "weather", "crawl", "stew" }; //Sets the words that it will be listening for
        string spokenWord; //I will be using this variable to store the word I spoke into the system
        string word = "crack"; //I am setting the initial word that it will be looking for to "crack"
        int count = 0; //This is the count variable I will be using to decide which word to ask for next
        int startNum = 0; //This is used so that pressing the button will ask for a word only the first time I press it

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Choices commands = new Choices(); //Usually the system is sets up the words expected to be commands. Our "commands" will be the 42 words given.
            commands.Add(myWords); //This adds my 42 words to the commands to be recognized (commands being a list of words).
            GrammarBuilder gBuilder = new GrammarBuilder(); //This is setting up the system that will understand the words
            gBuilder.Append(commands);
            Grammar grammar = new Grammar(gBuilder);

            recEngine.LoadGrammarAsync(grammar);
            recEngine.SetInputToDefaultAudioDevice();
            recEngine.SpeechRecognized += recEngine_SpeechRecognized;

        }

        private void disableBtn_Click(object sender, EventArgs e)
        {
            recEngine.RecognizeAsyncStop();
            disableBtn.Enabled = false;
        }

        private void mainForm_TextChanged(object sender, EventArgs e)
        {
            mainForm.SelectionStart = mainForm.Text.Length; //Sets the caret position to the end
            mainForm.ScrollToCaret(); //Scrolls to the position of the caret
        }

        private void recEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            count = count + 1;
            spokenWord = e.Result.Text;
            switch (e.Result.Text)
            {
                case "me":
                    if(spokenWord == word){
                        mainForm.Text += "\nGood Job! I heard you say \"me\".\n";
                    }
                    else{
                        mainForm.Text += "\nI heard \"" + spokenWord + "\" instead of \"" + word + "\".\n";
                    }
                    break;
                case "kiss":
                    if(spokenWord == word){
                        mainForm.Text += "\nGood Job! I heard you say \"kiss\".\n";
                    }
                    else{
                        mainForm.Text += "\nI heard \"" + spokenWord + "\" instead of \"" + word + "\".\n";
                    }
                    break;
                case "fluff":
                    if(spokenWord == word){
                        mainForm.Text += "\nGood Job! I heard you say \"fluff\".\n";
                    }
                    else{
                        mainForm.Text += "\nI heard \"" + spokenWord + "\" instead of \"" + word + "\".\n";
                    }
                    break;
                case "yell":
                    if(spokenWord == word){
                        mainForm.Text += "\nGood Job! I heard you say \"yell\".\n";
                    }
                    else{
                        mainForm.Text += "\nI heard \"" + spokenWord + "\" instead of \"" + word + "\".\n";
                    }
                    break;
                case "kind":
                    if(spokenWord == word){
                        mainForm.Text += "\nGood Job! I heard you say \"kind\".\n";
                    }
                    else{
                        mainForm.Text += "\nI heard \"" + spokenWord + "\" instead of \"" + word + "\".\n";
                    }
                    break;
                case "crack":
                    if(spokenWord == word){
                        mainForm.Text += "\nGood Job! I heard you say \"crack\".\n";
                    }
                    else{
                        mainForm.Text += "\nI heard \"" + spokenWord + "\" instead of \"" + word + "\".\n";
                    }
                    break;
                case "hope":
                    if(spokenWord == word){
                        mainForm.Text += "\nGood Job! I heard you say \"hope\".\n";
                    }
                    else{
                        mainForm.Text += "\nI heard \"" + spokenWord + "\" instead of \"" + word + "\".\n";
                    }
                    break;
                case "check":
                    if(spokenWord == word){
                        mainForm.Text += "\nGood Job! I heard you say \"check\".\n";
                    }
                    else{
                        mainForm.Text += "\nI heard \"" + spokenWord + "\" instead of \"" + word + "\".\n";
                    }
                    break;
                case "lake":
                    if(spokenWord == word){
                        mainForm.Text += "\nGood Job! I heard you say \"lake\".\n";
                    }
                    else{
                        mainForm.Text += "\nI heard \"" + spokenWord + "\" instead of \"" + word + "\".\n";
                    }
                    break;
                case "steep":
                    if(spokenWord == word){
                        mainForm.Text += "\nGood Job! I heard you say \"steep\".\n";
                    }
                    else{
                        mainForm.Text += "\nI heard \"" + spokenWord + "\" instead of \"" + word + "\".\n";
                    }
                    break;
                case "shell":
                    if(spokenWord == word){
                        mainForm.Text += "\nGood Job! I heard you say \"shell\".\n";
                    }
                    else{
                        mainForm.Text += "\nI heard \"" + spokenWord + "\" instead of \"" + word + "\".\n";
                    }
                    break;
                case "bark":
                    if(spokenWord == word){
                        mainForm.Text += "\nGood Job! I heard you say \"bark\".\n";
                    }
                    else{
                        mainForm.Text += "\nI heard \"" + spokenWord + "\" instead of \"" + word + "\".\n";
                    }
                    break;
                case "tooth":
                    if(spokenWord == word){
                        mainForm.Text += "\nGood Job! I heard you say \"tooth\".\n";
                    }
                    else{
                        mainForm.Text += "\nI heard \"" + spokenWord + "\" instead of \"" + word + "\".\n";
                    }
                    break;
                case "mouse":
                    if(spokenWord == word){
                        mainForm.Text += "\nGood Job! I heard you say \"mouse\".\n";
                    }
                    else{
                        mainForm.Text += "\nI heard \"" + spokenWord + "\" instead of \"" + word + "\".\n";
                    }
                    break;
                case "force":
                    if(spokenWord == word){
                        mainForm.Text += "\nGood Job! I heard you say \"force\".\n";
                    }
                    else{
                        mainForm.Text += "\nI heard \"" + spokenWord + "\" instead of \"" + word + "\".\n";
                    }
                    break;
                case "fringe":
                    if(spokenWord == word){
                        mainForm.Text += "\nGood Job! I heard you say \"fringe\".\n";
                    }
                    else{
                        mainForm.Text += "\nI heard \"" + spokenWord + "\" instead of \"" + word + "\".\n";
                    }
                    break;
                case "flight":
                    if(spokenWord == word){
                        mainForm.Text += "\nGood Job! I heard you say \"flight\".\n";
                    }
                    else{
                        mainForm.Text += "\nI heard \"" + spokenWord + "\" instead of \"" + word + "\".\n";
                    }
                    break;
                case "haunt":
                    if(spokenWord == word){
                        mainForm.Text += "\nGood Job! I heard you say \"haunt\".\n";
                    }
                    else{
                        mainForm.Text += "\nI heard \"" + spokenWord + "\" instead of \"" + word + "\".\n";
                    }
                    break;
                case "asked":
                    if(spokenWord == word){
                        mainForm.Text += "\nGood Job! I heard you say \"asked\".\n";
                    }
                    else{
                        mainForm.Text += "\nI heard \"" + spokenWord + "\" instead of \"" + word + "\".\n";
                    }
                    break;
                case "going":
                    if(spokenWord == word){
                        mainForm.Text += "\nGood Job! I heard you say \"going\".\n";
                    }
                    else{
                        mainForm.Text += "\nI heard \"" + spokenWord + "\" instead of \"" + word + "\".\n";
                    }
                    break;
                case "table":
                    if(spokenWord == word){
                        mainForm.Text += "\nGood Job! I heard you say \"table\".\n";
                    }
                    else{
                        mainForm.Text += "\nI heard \"" + spokenWord + "\" instead of \"" + word + "\".\n";
                    }
                    break;
                case "giant":
                    if(spokenWord == word){
                        mainForm.Text += "\nGood Job! I heard you say \"giant\".\n";
                    }
                    else{
                        mainForm.Text += "\nI heard \"" + spokenWord + "\" instead of \"" + word + "\".\n";
                    }
                    break;
                case "bully":
                    if(spokenWord == word){
                        mainForm.Text += "\nGood Job! I heard you say \"bully\".\n";
                    }
                    else{
                        mainForm.Text += "\nI heard \"" + spokenWord + "\" instead of \"" + word + "\".\n";
                    }
                    break;
                case "treated":
                    if(spokenWord == word){
                        mainForm.Text += "\nGood Job! I heard you say \"treated\".\n";
                    }
                    else{
                        mainForm.Text += "\nI heard \"" + spokenWord + "\" instead of \"" + word + "\".\n";
                    }
                    break;
                case "spying":
                    if(spokenWord == word){
                        mainForm.Text += "\nGood Job! I heard you say \"spying\".\n";
                    }
                    else{
                        mainForm.Text += "\nI heard \"" + spokenWord + "\" instead of \"" + word + "\".\n";
                    }
                    break;
                case "wiggle":
                    if(spokenWord == word){
                        mainForm.Text += "\nGood Job! I heard you say \"wiggle\".\n";
                    }
                    else{
                        mainForm.Text += "\nI heard \"" + spokenWord + "\" instead of \"" + word + "\".\n";
                    }
                    break;
                case "shredded":
                    if(spokenWord == word){
                        mainForm.Text += "\nGood Job! I heard you say \"shredded\".\n";
                    }
                    else{
                        mainForm.Text += "\nI heard \"" + spokenWord + "\" instead of \"" + word + "\".\n";
                    }
                    break;
                case "picnic":
                    if(spokenWord == word){
                        mainForm.Text += "\nGood Job! I heard you say \"picnic\".\n";
                    }
                    else{
                        mainForm.Text += "\nI heard \"" + spokenWord + "\" instead of \"" + word + "\".\n";
                    }
                    break;
                case "decoy":
                    if(spokenWord == word){
                        mainForm.Text += "\nGood Job! I heard you say \"decoy\".\n";
                    }
                    else{
                        mainForm.Text += "\nI heard \"" + spokenWord + "\" instead of \"" + word + "\".\n";
                    }
                    break;
                case "slaying":
                    if(spokenWord == word){
                        mainForm.Text += "\nGood Job! I heard you say \"slaying\".\n";
                    }
                    else{
                        mainForm.Text += "\nI heard \"" + spokenWord + "\" instead of \"" + word + "\".\n";
                    }
                    break;
                case "scheming":
                    if(spokenWord == word){
                        mainForm.Text += "\nGood Job! I heard you say \"scheming\".\n";
                    }
                    else{
                        mainForm.Text += "\nI heard \"" + spokenWord + "\" instead of \"" + word + "\".\n";
                    }
                    break;
                case "happier":
                    if(spokenWord == word){
                        mainForm.Text += "\nGood Job! I heard you say \"happier\".\n";
                    }
                    else{
                        mainForm.Text += "\nI heard \"" + spokenWord + "\" instead of \"" + word + "\".\n";
                    }
                    break;
                case "joyous":
                    if(spokenWord == word){
                        mainForm.Text += "\nGood Job! I heard you say \"joyous\".\n";
                    }
                    else{
                        mainForm.Text += "\nI heard \"" + spokenWord + "\" instead of \"" + word + "\".\n";
                    }
                    break;
                case "riotous":
                    if(spokenWord == word){
                        mainForm.Text += "\nGood Job! I heard you say \"riotous\".\n";
                    }
                    else{
                        mainForm.Text += "\nI heard \"" + spokenWord + "\" instead of \"" + word + "\".\n";
                    }
                    break;
                case "chow":
                    if(spokenWord == word){
                        mainForm.Text += "\nGood Job! I heard you say \"chow\".\n";
                    }
                    else{
                        mainForm.Text += "\nI heard \"" + spokenWord + "\" instead of \"" + word + "\".\n";
                    }
                    break;
                case "cookie":
                    if(spokenWord == word){
                        mainForm.Text += "\nGood Job! I heard you say \"cookie\".\n";
                    }
                    else{
                        mainForm.Text += "\nI heard \"" + spokenWord + "\" instead of \"" + word + "\".\n";
                    }
                    break;
                case "feud":
                    if(spokenWord == word){
                        mainForm.Text += "\nGood Job! I heard you say \"feud\".\n";
                    }
                    else{
                        mainForm.Text += "\nI heard \"" + spokenWord + "\" instead of \"" + word + "\".\n";
                    }
                    break;
                case "eighty":
                    if(spokenWord == word){
                        mainForm.Text += "\nGood Job! I heard you say \"eighty\".\n";
                    }
                    else{
                        mainForm.Text += "\nI heard \"" + spokenWord + "\" instead of \"" + word + "\".\n";
                    }
                    break;
                case "host":
                    if(spokenWord == word){
                        mainForm.Text += "\nGood Job! I heard you say \"host\".\n";
                    }
                    else{
                        mainForm.Text += "\nI heard \"" + spokenWord + "\" instead of \"" + word + "\".\n";
                    }
                    break;
                case "weather":
                    if(spokenWord == word){
                        mainForm.Text += "\nGood Job! I heard you say \"weather\".\n";
                    }
                    else{
                        mainForm.Text += "\nI heard \"" + spokenWord + "\" instead of \"" + word + "\".\n";
                    }
                    break;
                case "crawl":
                    if(spokenWord == word){
                        mainForm.Text += "\nGood Job! I heard you say \"crawl\".\n";
                    }
                    else{
                        mainForm.Text += "\nI heard \"" + spokenWord + "\" instead of \"" + word + "\".\n";
                    }
                    break;
                case "stew":
                    if(spokenWord == word){
                        mainForm.Text += "\nGood Job! I heard you say \"stew\".\n";
                    }
                    else{
                        mainForm.Text += "\nI heard \"" + spokenWord + "\" instead of \"" + word + "\".\n";
                    }
                    break;
            }

            //This is where we assign the words to say based on the current count
            switch (count)
            {
                case 1:
                    word = "wiggle";
                    mainForm.Text += "\nPlease say the word \"wiggle\":";
                    break;
                case 2:
                    word = "happier";
                    mainForm.Text += "\nPlease say the word \"happier\":";
                    break;
                case 3:
                    word = "feud";
                    mainForm.Text += "\nPlease say the word \"feud\":";
                    break;
                case 4:
                    word = "weather";
                    mainForm.Text += "\nPlease say the word \"weather\":";
                    break;
                case 5:
                    word = "picnic";
                    mainForm.Text += "\nPlease say the word \"picnic\":";
                    break;
                case 6:
                    word = "spying";
                    mainForm.Text += "\nPlease say the word \"spying\":";
                    break;
                case 7:
                    word = "chow";
                    mainForm.Text += "\nPlease say the word \"chow\":";
                    break;
                case 8:
                    word = "kiss";
                    mainForm.Text += "\nPlease say the word \"kiss\":";
                    break;
                case 9:
                    word = "check";
                    mainForm.Text += "\nPlease say the word \"check\":";
                    break;
                case 10:
                    word = "lake";
                    mainForm.Text += "\nPlease say the word \"lake\":";
                    break;
                default:
                    recEngine.RecognizeAsyncStop();
                    disableBtn.Enabled = false;
                    break;
            }           
            
        }

        private void enableBtn_Click(object sender, EventArgs e)
        {
            recEngine.RecognizeAsync(RecognizeMode.Multiple);
            disableBtn.Enabled = true;
            if (startNum == 0)
            {
                mainForm.Text += "\nPlease say the word \"crack\":";
                startNum = startNum + 1;
            }

        }
    }
}
