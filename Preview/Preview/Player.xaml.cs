using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Threading;
using Microsoft.CognitiveServices.Speech;
using Microsoft.CognitiveServices.Speech.Audio;
using System.Windows.Interop;
using System.Windows.Forms;
using NReco.VideoConverter;
using System.Media;

namespace Preview
{
    /// <summary>
    /// Логика взаимодействия для Player.xaml
    /// </summary>
    public partial class Player : Window
    {

        string InputFile;
        string Outputfile;

        public Player()
        {
            InitializeComponent();
        }

        private void BackPriviewBtn_Click(object sender, RoutedEventArgs e)
        {
            View.Position -= new TimeSpan(00, 00, 05);
        }

        private void BackPriviewBtn_MouseDown(object sender, MouseButtonEventArgs e)
        {
            View.Position -= new TimeSpan(00, 00, 02);

        }

        private void PlayPriviewBtn_Click(object sender, RoutedEventArgs e)
        {

            Thread t = new Thread(delegate ()
            {
                RecognizeSpeechAsync(Outputfile + ".wav").Wait();

            });
            t.Start();

            View.Play();


        }

        private void PausePriviewBtn_Click(object sender, RoutedEventArgs e)
        {
            View.Pause();



        }


        private void StopPriViewBtn_Click(object sender, RoutedEventArgs e)
        {
            View.Stop();
        }

        private void NextPriviewBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MutePriviewBtn_Click(object sender, RoutedEventArgs e)
        {

            double volum = View.Volume;
            bool on_off = true;
            if (on_off == false)
            {
                View.Volume = volum;
                on_off = true;
            }
            else
            {
                View.Volume = 0;
                on_off = false;
            }


        }
        byte[] bufer;
        int ofset, count;
        /// <summary>
        /// Сonverts speech to text
        /// </summary>
        /// <param name="AudioPath">путь к аудио файлу wav </param>
        /// <returns></returns>
        public async Task RecognizeSpeechAsync(string AudioPath)
        {
            SoundPlayer player = new SoundPlayer();
           
            player.SoundLocation=AudioPath;
            

            // Creates an instance of a speech config with specified subscription key and service region.
            // Replace with your own subscription key and service region (e.g., "westus").
            var config = SpeechConfig.FromSubscription("c14e2c4bf1ce4c5cb3baae64ffb4556d", "westus");


            var stopRecognition = new TaskCompletionSource<int>();

            // Creates a speech recognizer using file as audio input.
            // Replace with your own audio file name.
            
            using (AudioConfig audioInput = AudioConfig.FromWavFileInput(AudioPath))
            { 
                
                using (var recognizer = new SpeechRecognizer(config,audioInput))
                {
                    // Subscribes to events.

                    recognizer.Recognizing += (s, e) =>
                    {
                        RecognitionText.Dispatcher.Invoke((Action)(() =>
                        {
                            RecognitionText.Text = e.Result.Text;
                           
                            // EditSub.Text += e.Result.Text;
                            

                        }));

                        // RecognitionText.Text += e.Result.Text;

                    };

                    recognizer.Recognized += (s, e) =>
                    {
                        Thread.Sleep(30);
                        if (e.Result.Reason == ResultReason.RecognizedSpeech)
                        {


                            RecognitionText.Dispatcher.Invoke((Action)(() =>
                            {
                                RecognitionText.Text = e.Result.Text;
                                    //EditSub.Text += e.Result.Text;

                                }));

                        }

                        else if (e.Result.Reason == ResultReason.NoMatch)
                        {
                            RecognitionText.Dispatcher.Invoke((Action)(() =>
                            {
                                RecognitionText.Text += " NOMATCH: Speech could not be recognized.";
                            }));

                        }

                    };

                    recognizer.Canceled += (s, e) =>
                    {
                        RecognitionText.Dispatcher.Invoke((Action)(() =>
                        {
                            RecognitionText.Text = e.Result.Text;
                            // EditSub.Text += e.Result.Text;

                        }));

                        if (e.Reason == CancellationReason.Error)
                        {
                            RecognitionText.Dispatcher.Invoke((Action)(() =>
                            {
                                RecognitionText.Text += e.ErrorCode.ToString();
                                RecognitionText.Text += e.ErrorDetails;
                                RecognitionText.Text += "CANCELED: Did you update the subscription info?";
                            }));

                        }

                        
                    };

                    recognizer.SessionStarted += (s, e) =>
                    {
                        //Sub.Text = "\n    Session started event.";
                    };

                    recognizer.SessionStopped += (s, e) =>
                    {
                        //Sub.Text ="\n    Session stopped event.";
                        //Sub.Text = "\n Stop recognition.";
                        //Sub.Text = "\n Stop recognition.";
                        
                    };

                    // Starts continuous recognition. Uses StopContinuousRecognitionAsync() to stop recognition.
                    await recognizer.StartContinuousRecognitionAsync().ConfigureAwait(false);

                    // Waits for completion.
                    // Use Task.WaitAny to keep the task rooted.
                    Task.WaitAny(new[] { stopRecognition.Task });

                    // Stops recognition.
                    await recognizer.StopContinuousRecognitionAsync().ConfigureAwait(false);
                    Thread.Sleep(1000);

                }
            }

            // </recognitionContinuousWithFile>
        }

        private void OpenFile_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
            openFileDialog.Filter = "All Files (*.*)|*.*|mpg (*.mpg*.vob) | *.mpg;*.vob|avi (*.avi) | *.avi|Divx (*.divx) | *.divx|wmv (*.wmv)| *.wmv|QuickTime (*.mov)| *.mov|MP4 (*.mp4) | *.mp4|AVCHD (*.m2ts*.ts*.mts*m2t)|*.m2ts;*.ts;*.mts;*.m2t|wav (*.wav)|*.wav|MP3 (*.mp3)|*.mp3|WMA (*.wma)|*.wma||";
            if (openFileDialog.ShowDialog() == true)
            {
                string strFile = openFileDialog.FileName;
                Uri pathUri = new Uri(strFile);
                View.Source = pathUri;
                InputFile = strFile;
                Outputfile = InputFile.Substring(0,InputFile.LastIndexOf("."));

                var ConvertVideo = new NReco.VideoConverter.FFMpegConverter();
                ConvertVideo.ConvertMedia(InputFile, Outputfile + ".WAV", "WAV");
            }
        }
    }
}
