using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Net.Sockets;
using Thread = System.Threading.Thread;

namespace _7D2DServerTools
{
    public partial class Form1 : Form
    {
        private TcpClient client;
        private NetworkStream stream;
        private StreamReader reader;
        private StreamWriter writer;
        private Thread threadReader;
        private bool running;
        private List<string> lstConsoleOutput;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            pnlConnect.Visible = false;
            running = true;
            int port = Convert.ToInt32(txtServerPort.Text);
            client = new TcpClient(txtServerIP.Text, 8081);
            stream = client.GetStream();
            reader  = new StreamReader(stream);
            lstConsoleOutput = new List<string>();
            threadReader = new Thread(threadReader_func);
            threadReader.Start();
            tmrConsoleOutput.Enabled = true;
        }
        private void threadReader_func()
        {
            while (running)
            {
                string line = reader.ReadLine();
                lock (lstConsoleOutput) lstConsoleOutput.Add(line);
                Thread.Sleep(10);
            }
        }

        private void tmrConsoleOutput_Tick(object sender, EventArgs e)
        {
            lock (lstConsoleOutput)
            {
                while (lstConsoleOutput.Count > 0)
                {
                    string line = lstConsoleOutput[0];
                    lstConsoleOutput.RemoveAt(0);
                    txtConsoleOutput.Text += line+"\r\n";
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            client.Close();
            running = false;
        }
    }
}
