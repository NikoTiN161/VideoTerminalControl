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

        TelnetConnection tc = null;
        bool isMute = false;
        bool isMicMute = false;
        private int Volume;
        public Form1()
        {
            InitializeComponent();
            
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            send("exit");
        }
        public void connecting(string ip, int port)
        {
            tc = new TelnetConnection(ip, port);
            log.Text += '\n' + tc.Read();

            if (tc.IsConnected)
            {
                //login
                log.Text += '\n' + tc.Login("admin", "123456", 200);
                log.Text += '\n' + tc.Read();
 
                getVolume();
            } else
            {
                log.Text += '\n' + "нет подключения";
            }
        }

        private bool send(string command)
        {
            if ((tc != null) && (tc.IsConnected))
            {
                tc.Read();
                tc.WriteLine(command);
                return true;
            } else
            {
                log.Text += '\n' + "нет подключения";
                return false;
            }
        }

        private int getVolume()
        {
            if (send("volume get"))
            {
                string[] s = tc.Read().Split(new char[] { ' ' });
                if (TypeDescriptor.GetConverter(s[s.Length - 1]).CanConvertTo(typeof(int)))
                {
                    int result = Convert.ToInt32(s[s.Length - 1]);
                    toolStripStatusLabel2.Text = $"Текущая громкость: {result}";
                    return result;
                }
                else
                {
                    log.Text += '\n' + "не смог получить громкость";
                }

            }
            return -1;
        }

        private void volumeChangeOn(int i)
        {
            int vol = getVolume();
            if (vol != -1)
            {
                i += vol;
                send($"volume set {i}");
            }
            getVolume();
        }

        private void volumeSet(int i)
        {
            send($"volume set {i}");
            getVolume();
        }

        private void mute()
        {
            if (!isMute)
            {
                Volume = getVolume();
                send("volume set 0");
                muteBtn.BackgroundImage = VideoTerminalControl.Properties.Resources.volume;
                isMute = true;
            } else
            { 
                send($"volume set {Volume}");
                //print btn mute
                muteBtn.BackgroundImage = VideoTerminalControl.Properties.Resources.mute;
                isMute = false;
            }
        getVolume();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connecting(listBox1.SelectedItem.ToString(), 24);
            log.Text += '\n' + tc.Read();
            onConnect();

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
                log.Text += '\n' + tc.Read();
                
                // send client input to server
                send(prompt);

                // display server output
                log.Text += '\n' + tc.Read();
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
            if (button3.Text != "")
            {
            volumeSet(Convert.ToInt32(button3.Text));
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text != "")
            {
               volumeSet(Convert.ToInt32(button5.Text)); 
            }
            
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox2.Focused)
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    sendBtn_Click(sender, e);
                }
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            button5.Text = numericUpDown2.Value.ToString();
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            button3.Text = numericUpDown1.Value.ToString();
        }

        private void nowVol_Click(object sender, EventArgs e)
        {
            nowVol.Text = getVolume().ToString();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            volumeChangeOn(2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            volumeChangeOn(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            volumeChangeOn(8);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            volumeChangeOn(-2);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            volumeChangeOn(-5);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            volumeChangeOn(-8);
        }

        private void muteBtn_Click(object sender, EventArgs e)
        {
            mute();
        }

        private void micMuteBtn_Click(object sender, EventArgs e)
        {
            if (!isMicMute)
            {
                send("mute near on");
                micMuteBtn.BackgroundImage = VideoTerminalControl.Properties.Resources.mic;
                isMicMute = true;
            }
            else
            {
                send("mute near off");
                micMuteBtn.BackgroundImage = VideoTerminalControl.Properties.Resources.micMute;
                isMicMute = false;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            send("configlayout monitor1 full_screen");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            send("configlayout monitor1 side_by_side");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            send("configlayout monitor1 pip_lower_right");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            send("configlayout monitor1 pip_lower_left");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            send("configlayout monitor1 pip_upper_right");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            send("configlayout monitor1 pip_lower_left");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            send("exit");
        }

        private void onConnect()
        {         
            if (listBox1.SelectedItem.ToString() != null)
            {
                toolStripStatusLabel1.Text = "подключено к " + listBox1.SelectedItem.ToString();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            send("vcbutton play 3");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            send("vcbutton stop");
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            send("exit");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Form1.ActiveForm.TopMost = true;
            }
            else
            {
                Form1.ActiveForm.TopMost = false;
            }
        }
    }
}
