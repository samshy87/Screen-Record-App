using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;


namespace ScreenRecordApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
        }

        public int onOff = 0;
        Process cmd = new Process();
        private void recordStart_Click(object sender, EventArgs e)
        {
            if (onOff == 0)
            {
                onOff = 1;
                recordStart.Text = "Stop Recording";
                label1.Visible = true;
                string strCmdText;
                strCmdText = "ffmpeg -framerate 6 -f gdigrab -i desktop -c:v libx264 -pix_fmt yuv420p C:\\Users\\shysa\\Desktop\\TestRecordings\\test" + DateTime.Now.ToString("HH-mm-ss") + ".avi";
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.RedirectStandardInput = true;
                cmd.StartInfo.RedirectStandardOutput = true;
                cmd.StartInfo.CreateNoWindow = true;
                cmd.StartInfo.UseShellExecute = false;
                cmd.Start();
                cmd.StandardInput.WriteLine(strCmdText);
            }
            else if (onOff == 1)
            {
                onOff = 0;
                label1.Visible = false;
                recordStart.Text = "Start Recording";
                cmd.StandardInput.WriteLine("q");
            }

        }
        public void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            cmd.StandardInput.WriteLine("q");
        }

    }
}
