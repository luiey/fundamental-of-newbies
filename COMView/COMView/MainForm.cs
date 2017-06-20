using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMView
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnscan_Click(object sender, EventArgs e)
        {
            COMLibrary comport = new COMLibrary();
            var comdevice = comport.GetAllCOMPorts();
            if (comdevice.Count > 0)
            {
                portno.Items.Clear();
                foreach (var devinfo in comdevice)
                {
                    portno.Items.Add(devinfo.name);
                }
                portno.SelectedIndex = 0;
            }
            else
                MessageBox.Show("No COM were found on this system.","COM NOT FOUND!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
        }
    }
}
