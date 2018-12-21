using System;
using System.Net.NetworkInformation;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetMyIP
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            LanSetting_Load();
            comboBoxLanInternet.SelectedIndex = 0;
            Select();
            this.MaximumSize = this.Size;
        }

        private void LanSetting_Load()
        {
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                if ((nic.NetworkInterfaceType == NetworkInterfaceType.Ethernet) || (nic.NetworkInterfaceType == NetworkInterfaceType.Wireless80211)) //&& (nic.OperationalStatus == OperationalStatus.Up))
                {
                    foreach (UnicastIPAddressInformation ip in nic.GetIPProperties().UnicastAddresses)
                    {
                        if (!ip.Address.ToString().Contains("169.254"))
                        {
                            comboBoxLanInternet.Items.Add(nic.Description);
                        }
                    }
                }
            }
        }

        private void comboBoxLanInternet_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                foreach (UnicastIPAddressInformation ip in nic.GetIPProperties().UnicastAddresses)
                {
                    if (nic.Description == comboBoxLanInternet.SelectedItem.ToString())
                    {
                        if (ip.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                        {
                            textBoxIP.ResetText();
                            textBoxIP.Text = ip.Address.ToString();
                            this.ActiveControl = null;
                        }
                    }
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_NCHITTEST) 
            {
                m.Result = (IntPtr)(HT_CAPTION); // Enable drag and move MainForm
                return;
            }
            else if (m.Msg == WM_NCLBUTTONDBLCLK) // Disable Double click
            {
                m.Result = IntPtr.Zero;
                return;
            }
            base.WndProc(ref m);
        }

        // Enable drag and move MainForm
        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;
        // Disable Double click
        private const int WM_NCLBUTTONDBLCLK = 0x00A3;

        private void CopyrightLabel_Click(object sender, EventArgs e)
        {
            MessageBox.Show(GetMyIP.Properties.Resources.Copyright);
        }
    }
}
