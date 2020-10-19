using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoTerminalControl
{
    public partial class Form1 : Form
    {
        //create a new telnet connection to hostname "gobelijn" on port "23"
        TelnetConnection tc;

        public Form1()
        {
            InitializeComponent();
            
        }

        public void Form1_Load(object sender, EventArgs e)
        {
           
        }
        public string connecting(string ip, int port)
        {
            tc = new TelnetConnection(ip, port);
            string s = tc.Login("admin", "6008", 1000);
            return s;
        }

        private void send(string command)
        {
            tc.WriteLine(command);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = connecting(listBox1.SelectedItem.ToString(), 23);
             label1.Text += "Answer:\n" + s;

            // server output should end with "$" or ">", otherwise the connection failed
            //string prompt = s.TrimEnd();
            //prompt = s.Substring(prompt.Length - 1, 1);
            //if (prompt != "$" && prompt != ">")
            //    throw new Exception("Connection failed: promt" + prompt + "\n s: " + s);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string prompt = textBox2.Text;
            // while connected
            if (tc.IsConnected && prompt.Trim() != "exit")
            {
                // display server output
                label1.Text += '\n' + tc.Read();

                // send client input to server
                send(prompt);

                // display server output
                label1.Text += '\n' + tc.Read();
            }

            label2.Text = "DISCONNECTED";
        }
    }
}
