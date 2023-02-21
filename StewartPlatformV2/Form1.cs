using System;
using System.Threading;
using System.Windows.Forms;

namespace StewartPlatformV2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            serialPort1.Open();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void SendServoInfo(int channel, int pos)
        {
            string message = channel.ToString() + ':' + pos.ToString() + '*';
            try
            {
                serialPort1.Write(message);
            }
            catch
            {

            }
        }
        int minimumAngle = 0;
        int maximumAngle = 135;
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            trackBar1.Minimum = minimumAngle;
            trackBar1.Maximum = maximumAngle;
            trackBar1.TickFrequency = 1;
            int servoPos = trackBar1.Value;
            if (serialPort1.IsOpen)
            {
                label1.Text = "Position: " + servoPos.ToString();
                SendServoInfo(0, servoPos);
            }
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            trackBar2.Minimum = minimumAngle;
            trackBar2.Maximum = maximumAngle;
            trackBar2.TickFrequency = 1;
            int servoPos = trackBar2.Value;
            if (serialPort1.IsOpen)
            {
                label2.Text = "Position: " + servoPos.ToString();
                SendServoInfo(1, 180 - servoPos);
            }
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            trackBar3.Minimum = minimumAngle;
            trackBar3.Maximum = maximumAngle;
            trackBar3.TickFrequency = 1;
            int servoPos = trackBar3.Value;
            if (serialPort1.IsOpen)
            {
                label3.Text = "Position: " + servoPos.ToString();
                SendServoInfo(2, servoPos);
            }
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            trackBar4.Minimum = minimumAngle;
            trackBar4.Maximum = maximumAngle;
            trackBar4.TickFrequency = 1;
            int servoPos = trackBar4.Value;
            if (serialPort1.IsOpen)
            {
                label4.Text = "Position: " + servoPos.ToString();
                SendServoInfo(3, 180 - servoPos);
            }
        }

        private void trackBar5_Scroll(object sender, EventArgs e)
        {
            trackBar5.Minimum = minimumAngle;
            trackBar5.Maximum = maximumAngle;
            trackBar5.TickFrequency = 1;
            int servoPos = trackBar5.Value;
            if (serialPort1.IsOpen)
            {
                label5.Text = "Position: " + servoPos.ToString();
                SendServoInfo(4, servoPos);
            }
        }

        private void trackBar6_Scroll(object sender, EventArgs e)
        {
            trackBar6.Minimum = minimumAngle;
            trackBar6.Maximum = maximumAngle;
            trackBar6.TickFrequency = 1;
            int servoPos = trackBar6.Value;
            if (serialPort1.IsOpen)
            {
                label6.Text = "Position: " + servoPos.ToString();
                SendServoInfo(5, 180 - servoPos);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            int a = 0;
            for (int j = 0; j < 10; j++)
            {
                for (int i = 1; i < 4; i++)
                {
                    Thread.Sleep(200);
                    if (serialPort1.IsOpen)
                    {
                        if (j % 2 != 0)
                        {
                            a = 135;
                        }
                        else if (j % 2 == 0)
                        {
                            a = 45;
                        }
                        SendServoInfo(i * 2 - 2, a);
                        SendServoInfo(i * 2 - 1, 180 - a);
                        Console.WriteLine(i * 2 - 1);
                        Console.WriteLine(i * 2);
                        Console.WriteLine(j);
                        Console.WriteLine(180 - j);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int b = 0;
            for (int j = 0; j < 5; j++)
            {
                Thread.Sleep(1000);
                if (serialPort1.IsOpen)
                {
                    if (j % 2 != 0)
                    {
                        b = 135;
                    }
                    else if (j % 2 == 0)
                    {
                        b = 0;
                    }
                    SendServoInfo(0, b);
                    SendServoInfo(1, 180 - b);
                    SendServoInfo(2, b);
                    SendServoInfo(3, 180 - b);
                    SendServoInfo(4, b);
                    SendServoInfo(5, 180 - b);
                }
            }
        }

        private void trackBar7_Scroll(object sender, EventArgs e)
        {
            trackBar7.Minimum = minimumAngle;
            trackBar7.Maximum = maximumAngle;
            trackBar7.TickFrequency = 1;
            int servoPos = trackBar7.Value;
            if (serialPort1.IsOpen)
            {
                label7.Text = "Position: " + servoPos.ToString();
                label1.Text = "Position: " + servoPos.ToString();
                label2.Text = "Position: " + servoPos.ToString();
                label3.Text = "Position: " + servoPos.ToString();
                label4.Text = "Position: " + servoPos.ToString();
                label5.Text = "Position: " + servoPos.ToString();
                label6.Text = "Position: " + servoPos.ToString();
                SendServoInfo(0, servoPos);
                SendServoInfo(1, 180 - servoPos);
                SendServoInfo(2, servoPos);
                SendServoInfo(3, 180 - servoPos);
                SendServoInfo(4, servoPos);
                SendServoInfo(5, 180 - servoPos);
                trackBar1.Value = servoPos;
                trackBar2.Value = servoPos;
                trackBar3.Value = servoPos;
                trackBar4.Value = servoPos;
                trackBar5.Value = servoPos;
                trackBar6.Value = servoPos;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
