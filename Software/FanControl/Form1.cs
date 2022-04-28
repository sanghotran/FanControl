using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FanControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intlen;
        string txbuff;
        private void timer1_Tick(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            if (intlen != ports.Length)
            {
                intlen = ports.Length;
                cbo_Com.Items.Clear();
                for (int j = 0; j < intlen; j++)
                {
                    cbo_Com.Items.Add(ports[j]);
                }
            }
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            try
            {
                if (btn_Connect.Text == "Connect")
                {
                    COM.PortName = cbo_Com.Text;
                    COM.Open();
                    btn_Connect.Text = "Disconnect";
                    btn_Connect.ForeColor = Color.Red;
                    btn_ToggleDir.Enabled = true;
                    btn_EnablePWM.Enabled = true;
                }
                else if (btn_Connect.Text == "Disconnect")
                {
                    COM.Close();
                    btn_Connect.Text = "Connect";
                    btn_Connect.ForeColor = Color.Lime;
                    btn_ToggleDir.Enabled = false;
                    btn_SetPWM.Enabled = false;
                    btn_EnablePWM.Enabled = false;
                }
            }
            catch (Exception)
            { 
            }           
        }

        private void btn_ToggleDir_Click(object sender, EventArgs e)
        {
            txbuff = "0 \n";
            COM.Write(txbuff);
        }

        private void btn_EnablePWM_Click(object sender, EventArgs e)
        {
            if (btn_EnablePWM.Text == "Enable PWM")
            {
                btn_EnablePWM.Text = "Disable PWM";
                btn_EnablePWM.ForeColor = Color.Red;
                btn_SetPWM.Enabled = true;               
            }
            else if (btn_EnablePWM.Text == "Disable PWM")
            {
                btn_EnablePWM.Text = "Enable PWM";
                btn_Connect.ForeColor = Color.Lime;
                btn_SetPWM.Enabled = false;
            }
            txbuff = "1 \n";
            COM.Write(txbuff);

        }

        private void btn_SetPWM_Click(object sender, EventArgs e)
        {
            txbuff = "2 " + txt_setPWM.Text + "0 \n";
            COM.Write(txbuff);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn_ToggleDir.Enabled = false;
            btn_SetPWM.Enabled = false;
            btn_EnablePWM.Enabled = false;
        }
    }
}
