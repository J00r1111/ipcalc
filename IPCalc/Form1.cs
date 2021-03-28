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
using System.Text.RegularExpressions;


namespace IPCalc
{
    public partial class Form1 : Form
    {
        static Regex rgx = new Regex(@"(^\.)0+(?!\.|$)", RegexOptions.Compiled);
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateIP(object sender, EventArgs e)
        {
            String ipString = IPTextBox1.Text;
            ipString = rgx.Replace(ipString, ".");

            IPAddress ipAddress = IPAddress.Parse(IPTextBox1.Text);
            IPAddress maskAddress = IPAddress.Parse(MaskTextBox1.Text);
            byte[] ip = ipAddress.GetAddressBytes();
            byte[] mask = maskAddress.GetAddressBytes();
            byte[] reversedMask = maskAddress.GetAddressBytes();
            byte[] network = new byte[4];
            byte[] broadcast = new byte[4];
            for (int i = 0; i < 4; i++)
            {
                network[i] = (byte)(ip[i] & mask[i]);
                reversedMask[i] = (byte)~mask[i];
                broadcast[i] = (byte)(network[i] | reversedMask[i]);
            }
            string networkAddressString = "";
            string broadcastAddressString = "";
            for (int i = 0; i < 4; i++)
            {
                String ipFragment = network[i].ToString();
                ipFragment = ipFragment.PadLeft(3, '0');
                networkAddressString += ipFragment;

                ipFragment = broadcast[i].ToString();
                ipFragment = ipFragment.PadLeft(3, '0');
                broadcastAddressString += ipFragment;
            }
            networkAdressTextBox.Text = networkAddressString;
            BroadcastTextBox.Text = broadcastAddressString;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] ipAddress = new byte[4];
            ipAddress[0] = (byte)ipOctet1.Value;
            ipAddress[1] = (byte)ipOctet2.Value;
            ipAddress[2] = (byte)ipOctet3.Value;
            ipAddress[3] = (byte)ipOctet4.Value;
            IPAddress ip = new IPAddress(ipAddress);
            IPNetwork network = IPNetwork.Parse(ip.ToString(), (byte)cidrTexBox.Value);
            IPTextBox1.Text = network.Value;
            MaskTextBox1.Text = network.Netmask.ToString();
            networkAdressTextBox.Text = network.Network.ToString();
            BroadcastTextBox.Text = network.Broadcast.ToString();
            first.Text = network.FirstUsable.ToString();
            last.Text = network.LastUsable.ToString();
        }
    }
}
