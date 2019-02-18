using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Lightify
{
    public partial class Lightify : Form
    {

        private SerialPort port = new SerialPort("COM3", 9600);

        private void AskToOpenPort()
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show("The Serial Port is closed, do you want to open it again?", "Unexpected Error", buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                port.Open();
            }
        }

        public Lightify()
        {
            if (!port.IsOpen)
            {
                port.Open();
            }
           
            InitializeComponent();
        }

        private void static_button(object sender, EventArgs e)
        {

            ColorDialog colorDlg = new ColorDialog();
            colorDlg.AllowFullOpen = true;
            colorDlg.AnyColor = true;
            colorDlg.SolidColorOnly = false;
            colorDlg.Color = Color.Red;

            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                if (port.IsOpen)
                {
                    port.Write(colorDlg.Color.R.ToString() + "," + colorDlg.Color.G.ToString() + "," + colorDlg.Color.B.ToString() + ",1\n");
                }
                else
                {
                    AskToOpenPort();
                }
            }
        }

        private void fade_button(object sender, EventArgs e)
        {
            if (port.IsOpen)
            {
                port.Write("300,300,300,1\n");
            }
            else
            {
                AskToOpenPort();
            }
        }

        private void breath_button(object sender, EventArgs e)
        {
            if (port.IsOpen)
            {
                port.Write("302,302,302,1\n");
            }
            else
            {
                AskToOpenPort();
            }
        }

        private void party_button(object sender, EventArgs e)
        {
            if (port.IsOpen)
            {
                port.Write("301,301,301,1\n");
            }
            else
            {
                AskToOpenPort();
            }
        }

        private void ambilight_button(object sender, EventArgs e)
        {
            if (port.IsOpen)
            {
                port.Close();
            }

            System.Diagnostics.Process.Start(@"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Ambilight.lnk");
        }

        private void audioly_button(object sender, EventArgs e)
        {
            if (port.IsOpen)
            {
                port.Close();
            }

            System.Diagnostics.Process.Start(@"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Audioly.lnk");
        }

        private void COMport_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void turnoff_Click(object sender, EventArgs e)
        {
            if (port.IsOpen)
            {
                port.Write("0,0,0,1\n");
            }
            else
            {
                AskToOpenPort();
            }
        }
    }
}
