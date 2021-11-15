using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
using ServiceMtk_P1_20190140126;


namespace ServerConfigForm_P5_20190140126
{
    public partial class Form1 : Form
    {
        private ServiceHost Host;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Host = new ServiceHost(typeof(Matematika));

            labelOnOrOff.Text = "Server ON";
            labelKet.Text = "Klik OFF untuk Mematikan Server";
            Host.Open();
            ON.Enabled = false;
            OFF.Enabled = true;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void OFF_Click(object sender, EventArgs e)
        {
            ON.Enabled = true;
            OFF.Enabled = false;
            Host.Close();
            labelKet.Text = "Klik ON untuk menjalankan server";
            labelOnOrOff.Text = "Server OFF";
        }
    }
}
