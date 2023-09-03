using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Text;
using System.Windows.Forms;

namespace VoiceRecognition
{
    public partial class Form1 : Form
    {

        SpeechRecognitionEngine recEngine = new SpeechRecognitionEngine();
        SpeechSynthesizer synthesizer = new SpeechSynthesizer();

        public Form1()
        {
            InitializeComponent();
        }


        string[] data_personal =  { "Hello", "Hi", "How Are You" };

        string[] data_todo = {  "Open Google", "Open Facebook", "Open Youtube" };

        void recEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            try
            {
                string t_ = "Processing ";

                string voice_command_string = e.Result.Text;

                // rt_echo.Text += e.Result.Text;
                if (voice_command_string == data_personal[0])
                {
                    frmlist.addData(t_ + "-> " + data_personal[0]);
                    synthesizer.SpeakAsync("Command 1");
                }
                else if (voice_command_string == data_personal[1])
                {
                    frmlist.addData(t_ + "-> " + data_personal[1]);
                    synthesizer.SpeakAsync("Command 2");
                }
                else if (voice_command_string == data_personal[2])
                {
                    frmlist.addData(t_ + "-> " + data_personal[2]);
                    synthesizer.SpeakAsync("Command 3");
                }
                else if (voice_command_string == data_todo[0])
                {
                    frmlist.addData(t_ + "-> " + data_todo[0]);
                    synthesizer.SpeakAsync("Command 4 Executed");
                    Process.Start("https://www.google.com/");
                }
                else if (voice_command_string == data_todo[1])
                {
                    frmlist.addData(t_ + "-> " + data_todo[1]);
                    synthesizer.SpeakAsync("Command 5 Executed");
                    Process.Start("https://www.facebook.com/");
                }
                else if (voice_command_string == data_todo[2])
                {
                    frmlist.addData(t_ + "-> " + data_todo[2]);
                    synthesizer.SpeakAsync("Command 6 Executed");
                    Process.Start("https://www.youtube.com/");
                }
                else
                {
                    frmlist.addData("Searching...");
                    Process.Start("www.google.com/search?site=&source=hp&q=" + e.Result.Text);
                }
            }
            catch (Exception ex)
            {
                frmlist.addData("Error : " + ex.ToString());
            }
        }

        private Form2 frmlist = new Form2();
        private void Form1_Load(object sender, EventArgs e)
        {
            btn_disable_voice.Enabled = false;

            frmlist.Show();


            try
            {
                Choices commands = new Choices();
                commands.Add(new string[] {
                    data_personal[0]
                ,   data_personal[1]
                ,   data_personal[2]
                ,   data_todo[0]
                ,   data_todo[1]
                ,   data_todo[2]
                });

                GrammarBuilder gBuilder = new GrammarBuilder();
                gBuilder.Append(commands);
                Grammar grammar = new Grammar(gBuilder);

                recEngine.LoadGrammarAsync(grammar);
                recEngine.SetInputToDefaultAudioDevice();
                recEngine.SpeechRecognized += recEngine_SpeechRecognized;
            }
            catch
            {

            }
        }

        private void btn_enable_voice_Click(object sender, EventArgs e)
        {
            recEngine.RecognizeAsync(RecognizeMode.Multiple);
            btn_enable_voice.Enabled = false;
            btn_disable_voice.Enabled = true;
        }

        private void btn_disable_voice_Click(object sender, EventArgs e)
        {
            recEngine.RecognizeAsyncStop();
            btn_enable_voice.Enabled = true;
            btn_disable_voice.Enabled = false;
        }

        private void btn_talk_Click(object sender, EventArgs e)
        {
            if (rt_echo.Text == string.Empty)
            {
                return;
            }
            synthesizer.SpeakAsync(rt_echo.Text);
        }
        private void printAllComand()
        {
            int lengtData = data_personal.Length;
            frmlist.clearCommand();
            for (int i = 0; i < lengtData; i++)
            {
                frmlist.addData("- " + data_personal[i]);
            }
            int lengthTodo = data_todo.Length;

            for (int j = 0; j < lengthTodo; j++)
            {
                frmlist.addData(" - " + data_todo[j]);
            }
        }

        private void btn_print_command_Click(object sender, EventArgs e)
        {
            printAllComand();
        }
    }
}
