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

        TelnetConnection tc;
        bool isMute = false;
        int Volume;

        public Form1()
        {
            InitializeComponent();
            
        }

        public void Form1_Load(object sender, EventArgs e)
        {
           
        }
        public void connecting(string ip, int port)
        {
            tc = new TelnetConnection(ip, port);
            richTextBox1.Text += '\n' + tc.Read();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label6.Text = tc.Login("admin", "123456", 200);
            
            richTextBox1.Text += '\n' + tc.Read();
 
        }

        private void send(string command)
        {
            tc.WriteLine(command);
        }

        private int getVolume()
        {
            
            send("volume get");

            string[] s = tc.Read().Split(new char[] { ' ' });
            int result = Convert.ToInt32(s[2]); 

            if ()
            {

            }
            

            return result; 
        }

        private void volumeChangeOn(int i)
        {
            i += getVolume();
            send($"volume set {i}");
        }

        private void volumeSet(int i)
        {
            send($"volume set {i}");
        }

        private void mute()
        {
            if (!isMute)
            {
                Volume = getVolume();
                send("volume set 0");
            } else
            {
                send($"volume set {Volume}");
            }
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            connecting(listBox1.SelectedItem.ToString(), Convert.ToInt32(numericUpDown1.Value));
            richTextBox1.Text += '\n' + tc.Read();

            // server output should end with "$" or ">", otherwise the connection failed
            //string prompt = s.TrimEnd();
            //prompt = s.Substring(prompt.Length - 1, 1);
            //if (prompt != "$" && prompt != ">")
            //    throw new Exception("Connection failed: promt" + prompt + "\n s: " + s);

        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            string prompt = textBox2.Text;
            // while connected
            if (tc.IsConnected && prompt.Trim() != "exit")
            {
                // display server output
                richTextBox1.Text += '\n' + tc.Read();
                
                // send client input to server
                send(prompt);

                // display server output
                richTextBox1.Text += '\n' + tc.Read();
            }
            else
            {
                send(prompt);
                label2.Text = "DISCONNECTED";
            }

            textBox2.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void button2_Click(object sender, EventArgs e)
        {
           label6.Text = getVolume().ToString();
        }
    }
}
