using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Threading;
using System.Diagnostics;

namespace SpeechRecg_KodTurkiye
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SpeechSynthesizer synt = new SpeechSynthesizer();
        PromptBuilder pbuilder = new PromptBuilder();
        SpeechRecognitionEngine rEngine = new SpeechRecognitionEngine();

        private void button1_Click(object sender, EventArgs e)
        {
            Choices list = new Choices();
            list.Add(new String[] {"go back","bigger", "UP", "DOWN", "LEFT", "RIGHT", "exit", "open", "open chrome", "open game one", "open game two", "open game three", "open panorama one", "open panorama two", "open panorama final", "enter","open command","lets go" });

            Grammar gramer = new Grammar(new GrammarBuilder(list));
            try
            {
                rEngine.RequestRecognizerUpdate();
                rEngine.LoadGrammar(gramer);

                rEngine.SpeechRecognized += rEngine_SpeechRecognized;
                rEngine.SetInputToDefaultAudioDevice();
                rEngine.RecognizeAsync(RecognizeMode.Multiple);
            }
            catch (Exception z)
            {
                Console.WriteLine(z);
                return;
            }
        }


        void rEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {

            Console.WriteLine(e.Result.Text);


            switch (e.Result.Text)
            {
                case "open chrome":
                    {
                        System.Diagnostics.Process.Start("C:/Program Files (x86)/Google/Chrome/Application/chrome.exe");
                        pbuilder.ClearContent();
                        pbuilder.AppendText("very well OPEN CHROME");
                        synt.Speak(pbuilder);
                        break;
                    }
                case "open game one":
                    {
                        System.Diagnostics.Process.Start("C:/PROJE/OYUN_1/sanal_gerceklik.exe");
                        pbuilder.ClearContent();
                        pbuilder.AppendText("very well OPEN game one");
                        synt.Speak(pbuilder);
                        break;
                    }
                case "open game two":
                    {
                        System.Diagnostics.Process.Start("C:/PROJE/OYUN_2/odev_oyun.exe");
                        pbuilder.ClearContent();
                        pbuilder.AppendText("very well OPEN game two");
                        synt.Speak(pbuilder);
                        break;
                    }
                case "open game three":
                    {
                        System.Diagnostics.Process.Start("C:/PROJE/OYUN_3/odev_oyun_3.exe");
                        pbuilder.ClearContent();
                        pbuilder.AppendText("very well OPEN game three");
                        synt.Speak(pbuilder);
                        break;
                    }
                case "open panorama one":
                    {
                        System.Diagnostics.Process.Start("C:/PROJE/PANORAMA_1/PANORAMA_1.exe");
                        pbuilder.ClearContent();
                        pbuilder.AppendText("very well OPEN PANORAMA ONE");
                        synt.Speak(pbuilder);
                        break;
                    }
                case "open panorama two":
                    {
                        System.Diagnostics.Process.Start("C:/PROJE/PANORAMA_2/PANORAMA_2.html");
                        pbuilder.ClearContent();
                        pbuilder.AppendText("very well OPEN PANORAMA TWO");
                        synt.Speak(pbuilder);
                        break;
                    }
                case "open panorama final":
                    {
                        System.Diagnostics.Process.Start("C:/PROJE/PANORAMA_3/PANORAMA_3.html");
                        pbuilder.ClearContent();
                        pbuilder.AppendText("very well OPEN PANORAMA final");
                        synt.Speak(pbuilder);
                        break;
                    }
                case "open command":
                    {
                        System.Diagnostics.Process.Start("C:/PROJE/KOMUTLAR.txt");
                        pbuilder.ClearContent();
                        pbuilder.AppendText("YES SIR OPEN command");
                        synt.Speak(pbuilder);
                        break;
                    }
                case "enter":
                    {

                        pbuilder.ClearContent();
                        pbuilder.AppendText("okey enter");
                        SendKeys.Send("{ENTER}");

                        synt.Speak(pbuilder);
                        break;
                    }

                case "bigger":
                    {

                        pbuilder.ClearContent();
                        pbuilder.AppendText("okey bigger");
                        SendKeys.Send("{ENTER}");
                        SendKeys.Send("{ENTER}");
                        synt.Speak(pbuilder);
                        break;
                    }
                case "UP":
                    {

                        pbuilder.ClearContent();
                        pbuilder.AppendText("turn UP");
                        SendKeys.Send("{UP}");

                        synt.Speak(pbuilder);
                        break;
                    }

                case "lets go":
                    {

                        pbuilder.ClearContent();
                        pbuilder.AppendText("LETS GO");
                        SendKeys.Send("{UP}");
                        SendKeys.Send("{UP}");
                        SendKeys.Send("{UP}");
                        SendKeys.Send("{UP}");
                        SendKeys.Send("{UP}");
                        SendKeys.Send("{UP}");
                        SendKeys.Send("{UP}");
                        SendKeys.Send("{UP}");
                        SendKeys.Send("{UP}");
                        SendKeys.Send("{UP}");
                        SendKeys.Send("{UP}");
                        SendKeys.Send("{UP}");
                        SendKeys.Send("{UP}");
                        SendKeys.Send("{UP}");
                        SendKeys.Send("{UP}");
                        SendKeys.Send("{UP}");
                        SendKeys.Send("{UP}");
                        SendKeys.Send("{UP}");
                        synt.Speak(pbuilder);
                        break;
                    }
                case "DOWN":
                    {

                        pbuilder.ClearContent();
                        pbuilder.AppendText("turn DOWN");
                        SendKeys.Send("{DOWN}");

                        synt.Speak(pbuilder);
                        break;
                    }
                case "go back":
                    {

                        pbuilder.ClearContent();
                        pbuilder.AppendText("go back");
                        SendKeys.Send("{DOWN}");
                        SendKeys.Send("{DOWN}");
                        SendKeys.Send("{DOWN}");
                        SendKeys.Send("{DOWN}");
                        SendKeys.Send("{DOWN}");
                        SendKeys.Send("{DOWN}");
                        SendKeys.Send("{DOWN}");
                        SendKeys.Send("{DOWN}");
                        SendKeys.Send("{DOWN}");
                        SendKeys.Send("{DOWN}");
                        SendKeys.Send("{DOWN}");
                        SendKeys.Send("{DOWN}");
                        SendKeys.Send("{DOWN}");
                        SendKeys.Send("{DOWN}");
                        SendKeys.Send("{DOWN}");
                        SendKeys.Send("{DOWN}");
                        SendKeys.Send("{DOWN}");
                        SendKeys.Send("{DOWN}");
                        SendKeys.Send("{DOWN}");
                        SendKeys.Send("{DOWN}");

                        synt.Speak(pbuilder);
                        break;
                    }
                case "LEFT":
                    {

                        pbuilder.ClearContent();
                        pbuilder.AppendText("turn LEFT");
                        SendKeys.Send("{LEFT}");

                        synt.Speak(pbuilder);
                        break;
                    }

                case "RIGHT":
                    {

                        pbuilder.ClearContent();
                        pbuilder.AppendText("turn RIGHT");
                        SendKeys.Send("{RIGHT}");

                        synt.Speak(pbuilder);
                        break;
                    }



                case "exit":
                        Application.Exit();
                        break;
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rEngine.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
           
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("C:/PROJE/KOMUTLAR.txt");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
