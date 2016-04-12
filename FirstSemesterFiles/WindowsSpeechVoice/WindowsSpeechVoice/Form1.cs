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

namespace WindowsSpeechVoice
{
    public partial class Form1 : Form
    {
        SpeechRecognitionEngine recEngine = new SpeechRecognitionEngine();
        string[] myWords = new string[] { "me", "kiss", "fluff", "yell", "kind", "crack", "hope", "check", "lake", "steep", "shell", "bark", "tooth", "mouse", "force", "fringe", "flight", "haunt", "asked", "going", "table", "giant", "bully", "treated", "spying", "wiggle", "shredded", "picnic", "decoy", "slaying", "scheming", "happier", "joyous", "riotous", "chow", "cookie", "feud", "eighty", "host", "weather", "crawl", "stew" };
        string word;
        string spokenWord;
        Random r = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void enableBtn_Click(object sender, EventArgs e)
        {
            recEngine.RecognizeAsync(RecognizeMode.Multiple);
            disableBtn.Enabled = true;
        }

        private void mainForm_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void disableBtn_Click(object sender, EventArgs e)
        {
            recEngine.RecognizeAsyncStop();
            disableBtn.Enabled = false;
        }

        private void recEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            spokenWord = e.Result.Text;
            switch (e.Result.Text)
            {
                case "me":
                    if(spokenWord == word){
                        mainForm.Text += "\nGood Job! You correctly said \"me\".\n";
                    }
                    else{
                        mainForm.Text += "\nI heard \"" + spokenWord + "\" instead of \"" + word + "\".\n";
                    }
                    break;
                case "kiss":
                    if(spokenWord == word){
                        mainForm.Text += "\nGood Job! You correctly said \"kiss\".\n";
                    }
                    else{
                        mainForm.Text += "\nI heard \"" + spokenWord + "\" instead of \"" + word + "\".\n";
                    }
                    break;
                case "fluff":
                    if(spokenWord == word){
                        mainForm.Text += "\nGood Job! You correctly said \"fluff\".\n";
                    }
                    else{
                        mainForm.Text += "\nI heard \"" + spokenWord + "\" instead of \"" + word + "\".\n";
                    }
                    break;
                case "yell":
                    if(spokenWord == word){
                        mainForm.Text += "\nGood Job! You correctly said \"yell\".\n";
                    }
                    else{
                        mainForm.Text += "\nI heard \"" + spokenWord + "\" instead of \"" + word + "\".\n";
                    }
                    break;
                case "kind":
                    if(spokenWord == word){
                        mainForm.Text += "\nGood Job! You correctly said \"kind\".\n";
                    }
                    else{
                        mainForm.Text += "\nI heard \"" + spokenWord + "\" instead of \"" + word + "\".\n";
                    }
                    break;
                case "crack":
                    if(spokenWord == word){
                        mainForm.Text += "\nGood Job! You correctly said \"crack\".\n";
                    }
                    else{
                        mainForm.Text += "\nI heard \"" + spokenWord + "\" instead of \"" + word + "\".\n";
                    }
                    break;
                case "hope":
                    if(spokenWord == word){
                        mainForm.Text += "\nGood Job! You correctly said \"hope\".\n";
                    }
                    else{
                        mainForm.Text += "\nI heard \"" + spokenWord + "\" instead of \"" + word + "\".\n";
                    }
                    break;
                case "check":
                    if(spokenWord == word){
                        mainForm.Text += "\nGood Job! You correctly said \"check\".\n";
                    }
                    else{
                        mainForm.Text += "\nI heard \"" + spokenWord + "\" instead of \"" + word + "\".\n";
                    }
                    break;
                case "lake":
                    if(spokenWord == word){
                        mainForm.Text += "\nGood Job! You correctly said \"lake\".\n";
                    }
                    else{
                        mainForm.Text += "\nI heard \"" + spokenWord + "\" instead of \"" + word + "\".\n";
                    }
                    break;
                case "steep":
                    if(spokenWord == word){
                        mainForm.Text += "\nGood Job! You correctly said \"steep\".\n";
                    }
                    else{
                        mainForm.Text += "\nI heard \"" + spokenWord + "\" instead of \"" + word + "\".\n";
                    }
                    break;
                case "shell":
                    if(spokenWord == word){
                        mainForm.Text += "\nGood Job! You correctly said \"shell\".\n";
                    }
                    else{
                        mainForm.Text += "\nI heard \"" + spokenWord + "\" instead of \"" + word + "\".\n";
                    }
                    break;
                case "bark":
                    if(spokenWord == word){
                        mainForm.Text += "\nGood Job! You correctly said \"bark\".\n";
                    }
                    else{
                        mainForm.Text += "\nI heard \"" + spokenWord + "\" instead of \"" + word + "\".\n";
                    }
                    break;
                case "tooth":
                    if(spokenWord == word){
                        mainForm.Text += "\nGood Job! You correctly said \"tooth\".\n";
                    }
                    else{
                        mainForm.Text += "\nI heard \"" + spokenWord + "\" instead of \"" + word + "\".\n";
                    }
                    break;
                case "mouse":
                    if(spokenWord == word){
                        mainForm.Text += "\nGood Job! You correctly said \"mouse\".\n";
                    }
                    else{
                        mainForm.Text += "\nI heard \"" + spokenWord + "\" instead of \"" + word + "\".\n";
                    }
                    break;
                case "force":
                    if(spokenWord == word){
                        mainForm.Text += "\nGood Job! You correctly said \"force\".\n";
                    }
                    else{
                        mainForm.Text += "\nI heard \"" + spokenWord + "\" instead of \"" + word + "\".\n";
                    }
                    break;
                case "fringe":
                    if(spokenWord == word){
                        mainForm.Text += "\nGood Job! You correctly said \"fringe\".\n";
                    }
                    else{
                        mainForm.Text += "\nI heard \"" + spokenWord + "\" instead of \"" + word + "\".\n";
                    }
                    break;
                case "flight":
                    if(spokenWord == word){
                        mainForm.Text += "\nGood Job! You correctly said \"flight\".\n";
                    }
                    else{
                        mainForm.Text += "\nI heard \"" + spokenWord + "\" instead of \"" + word + "\".\n";
                    }
                    break;
                case "haunt":
                    if(spokenWord == word){
                        mainForm.Text += "\nGood Job! You correctly said \"haunt\".\n";
                    }
                    else{
                        mainForm.Text += "\nI heard \"" + spokenWord + "\" instead of \"" + word + "\".\n";
                    }
                    break;
                case "asked":
                    if(spokenWord == word){
                        mainForm.Text += "\nGood Job! You correctly said \"asked\".\n";
                    }
                    else{
                        mainForm.Text += "\nI heard \"" + spokenWord + "\" instead of \"" + word + "\".\n";
                    }
                    break;
                case "going":
                    if(spokenWord == word){
                        mainForm.Text += "\nGood Job! You correctly said \"going\".\n";
                    }
                    else{
                        mainForm.Text += "\nI heard \"" + spokenWord + "\" instead of \"" + word + "\".\n";
                    }
                    break;
                case "table":
                    if(spokenWord == word){
                        mainForm.Text += "\nGood Job! You correctly said \"table\".\n";
                    }
                    else{
                        mainForm.Text += "\nI heard \"" + spokenWord + "\" instead of \"" + word + "\".\n";
                    }
                    break;
                case "giant":
                    if(spokenWord == word){
                        mainForm.Text += "\nGood Job! You correctly said \"giant\".\n";
                    }
                    else{
                        mainForm.Text += "\nI heard \"" + spokenWord + "\" instead of \"" + word + "\".\n";
                    }
                    break;
                case "bully":
                    if(spokenWord == word){
                        mainForm.Text += "\nGood Job! You correctly said \"bully\".\n";
                    }
                    else{
                        mainForm.Text += "\nI heard \"" + spokenWord + "\" instead of \"" + word + "\".\n";
                    }
                    break;
                case "treated":
                    if(spokenWord == word){
                        mainForm.Text += "\nGood Job! You correctly said \"treated\".\n";
                    }
                    else{
                        mainForm.Text += "\nI heard \"" + spokenWord + "\" instead of \"" + word + "\".\n";
                    }
                    break;
                case "spying":
                    if(spokenWord == word){
                        mainForm.Text += "\nGood Job! You correctly said \"spying\".\n";
                    }
                    else{
                        mainForm.Text += "\nI heard \"" + spokenWord + "\" instead of \"" + word + "\".\n";
                    }
                    break;
                case "wiggle":
                    if(spokenWord == word){
                        mainForm.Text += "\nGood Job! You correctly said \"wiggle\".\n";
                    }
                    else{
                        mainForm.Text += "\nI heard \"" + spokenWord + "\" instead of \"" + word + "\".\n";
                    }
                    break;
                case "shredded":
                    if(spokenWord == word){
                        mainForm.Text += "\nGood Job! You correctly said \"shredded\".\n";
                    }
                    else{
                        mainForm.Text += "\nI heard \"" + spokenWord + "\" instead of \"" + word + "\".\n";
                    }
                    break;
                case "picnic":
                    if(spokenWord == word){
                        mainForm.Text += "\nGood Job! You correctly said \"picnic\".\n";
                    }
                    else{
                        mainForm.Text += "\nI heard \"" + spokenWord + "\" instead of \"" + word + "\".\n";
                    }
                    break;
                case "decoy":
                    if(spokenWord == word){
                        mainForm.Text += "\nGood Job! You correctly said \"decoy\".\n";
                    }
                    else{
                        mainForm.Text += "\nI heard \"" + spokenWord + "\" instead of \"" + word + "\".\n";
                    }
                    break;
                case "slaying":
                    if(spokenWord == word){
                        mainForm.Text += "\nGood Job! You correctly said \"slaying\".\n";
                    }
                    else{
                        mainForm.Text += "\nI heard \"" + spokenWord + "\" instead of \"" + word + "\".\n";
                    }
                    break;
                case "scheming":
                    if(spokenWord == word){
                        mainForm.Text += "\nGood Job! You correctly said \"scheming\".\n";
                    }
                    else{
                        mainForm.Text += "\nI heard \"" + spokenWord + "\" instead of \"" + word + "\".\n";
                    }
                    break;
                case "happier":
                    if(spokenWord == word){
                        mainForm.Text += "\nGood Job! You correctly said \"happier\".\n";
                    }
                    else{
                        mainForm.Text += "\nI heard \"" + spokenWord + "\" instead of \"" + word + "\".\n";
                    }
                    break;
                case "joyous":
                    if(spokenWord == word){
                        mainForm.Text += "\nGood Job! You correctly said \"joyous\".\n";
                    }
                    else{
                        mainForm.Text += "\nI heard \"" + spokenWord + "\" instead of \"" + word + "\".\n";
                    }
                    break;
                case "riotous":
                    if(spokenWord == word){
                        mainForm.Text += "\nGood Job! You correctly said \"riotous\".\n";
                    }
                    else{
                        mainForm.Text += "\nI heard \"" + spokenWord + "\" instead of \"" + word + "\".\n";
                    }
                    break;
                case "chow":
                    if(spokenWord == word){
                        mainForm.Text += "\nGood Job! You correctly said \"chow\".\n";
                    }
                    else{
                        mainForm.Text += "\nI heard \"" + spokenWord + "\" instead of \"" + word + "\".\n";
                    }
                    break;
                case "cookie":
                    if(spokenWord == word){
                        mainForm.Text += "\nGood Job! You correctly said \"cookie\".\n";
                    }
                    else{
                        mainForm.Text += "\nI heard \"" + spokenWord + "\" instead of \"" + word + "\".\n";
                    }
                    break;
                case "feud":
                    if(spokenWord == word){
                        mainForm.Text += "\nGood Job! You correctly said \"feud\".\n";
                    }
                    else{
                        mainForm.Text += "\nI heard \"" + spokenWord + "\" instead of \"" + word + "\".\n";
                    }
                    break;
                case "eighty":
                    if(spokenWord == word){
                        mainForm.Text += "\nGood Job! You correctly said \"eighty\".\n";
                    }
                    else{
                        mainForm.Text += "\nI heard \"" + spokenWord + "\" instead of \"" + word + "\".\n";
                    }
                    break;
                case "host":
                    if(spokenWord == word){
                        mainForm.Text += "\nGood Job! You correctly said \"host\".\n";
                    }
                    else{
                        mainForm.Text += "\nI heard \"" + spokenWord + "\" instead of \"" + word + "\".\n";
                    }
                    break;
                case "weather":
                    if(spokenWord == word){
                        mainForm.Text += "\nGood Job! You correctly said \"weather\".\n";
                    }
                    else{
                        mainForm.Text += "\nI heard \"" + spokenWord + "\" instead of \"" + word + "\".\n";
                    }
                    break;
                case "crawl":
                    if(spokenWord == word){
                        mainForm.Text += "\nGood Job! You correctly said \"crawl\".\n";
                    }
                    else{
                        mainForm.Text += "\nI heard \"" + spokenWord + "\" instead of \"" + word + "\".\n";
                    }
                    break;
                case "stew":
                    if(spokenWord == word){
                        mainForm.Text += "\nGood Job! You correctly said \"stew\".\n";
                    }
                    else{
                        mainForm.Text += "\nI heard \"" + spokenWord + "\" instead of \"" + word + "\".\n";
                    }
                    break;
            }

            word = myWords[r.Next(0, myWords.Length)];
            mainForm.Text += "\nPlease say the word \"" + word + "\":";
           
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Choices commands = new Choices();
            commands.Add(myWords);
            GrammarBuilder gBuilder = new GrammarBuilder();
            gBuilder.Append(commands);
            Grammar grammar = new Grammar(gBuilder);

            recEngine.LoadGrammarAsync(grammar);
            recEngine.SetInputToDefaultAudioDevice();
            recEngine.SpeechRecognized += recEngine_SpeechRecognized;

            word = myWords[r.Next(0, myWords.Length)];
            mainForm.Text += "\nPlease say the word \"" + word + "\":";

        }
    }
}
