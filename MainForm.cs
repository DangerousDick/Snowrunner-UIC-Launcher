using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;   // for process class to launch game

namespace SnowrunnerLauncher
{
    public partial class MainForm : Form
    {
        // create logger
        static private string LogFileName = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\SnowrunerLauncher.log";
        static private Logger logger = new Logger(LogFileName, true);
        // exe files to launch
        static private string snowrunner = "SnowRunner.exe";
        static private string snowrunneruic = "SRUICInjector.exe";

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnBrowseSR_Click(object sender, EventArgs e)
        {
            /*
             * snowrunner path browse button clicked so launch 
             * file dialog to select or create new folder
             */
            using (FolderBrowserDialog ofd = new FolderBrowserDialog())
            {
                try
                {
                    string init_dir = txtSnowrunnerPath.Text;
                    if (!Directory.Exists(init_dir))
                    {
                        init_dir = "C:\\";
                    }
                    //ofd.InitialDirectory = init_dir;

                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        //Show in textbox
                        txtSnowrunnerPath.Text = ofd.SelectedPath;
                    }
                }
                catch (Exception ex)
                {
                    logger.LogWrite(ex.Message, true);
                }
            }
        }

        private void btnLaunchGame_Click(object sender, EventArgs e)
        {
            /*
             * launch the snowrunner game followed by the sruic delayed by value of numDelay
             */
            // launch snowrunner
            run_exe_proces(string.Join("\\", txtSnowrunnerPath.Text, snowrunner));
            // wait for delay then launch sruic
            run_exe_proces(string.Join("\\", txtSnowrunnerPath.Text, snowrunneruic), Decimal.ToInt32(numDelay.Value), chkSRUIC.Checked);
        }

        private async void run_exe_proces(string exe_name, int delayTime = 0, bool sruicDelay = false)
        {
            /*
             * Launch a process such as the snowruneer exe file
             */
            // join arguments
            logger.LogWrite("Starting process: " + exe_name, true);

            // Use ProcessStartInfo class
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = false;
            startInfo.UseShellExecute = true;
            startInfo.FileName = exe_name;
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;

            try
            {
                if (sruicDelay)
                {
                    logger.LogWrite($"launching {snowrunneruic} with {delayTime} delay");
                    DateTime target = DateTime.Now.AddSeconds(delayTime);
                    logger.LogWrite($"target time = {target.ToString()}");
                    while (DateTime.Now < target) { };
                    Process exeProcess = Process.Start(startInfo);
                    logger.LogWrite($"delaying for {delayTime} seconds");
                }
                else
                {
                    logger.LogWrite($"launching {snowrunner}");
                    Process exeProcess = Process.Start(startInfo);
                }
            }
            catch (Exception ex)
            {
                logger.LogWrite(ex.Message, true);
            }
        }
        public void wait(int milliseconds)
        {
            var timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;

            // Console.WriteLine("start wait timer");
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();

            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
                // Console.WriteLine("stop wait timer");
            };

            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }
    }
}
