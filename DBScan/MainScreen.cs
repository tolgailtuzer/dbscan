using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBScan
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        CultureInfo cultureInfo = new CultureInfo("en");
        private void chooseFile_Click(object sender, EventArgs e)
        {
            try
            {
                selectionPanel.Height = chooseFile.Height;
                selectionPanel.Top = chooseFile.Top;
                openFileDialog1.Filter = "CSV Files (*.csv)|*.csv";
                openFileDialog1.ShowDialog();
                FileOperations.path = openFileDialog1.FileName;
            }         
            catch(Exception ex)
            {
                MessageBox.Show("Please choose a valid file.", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void algorithm_Click(object sender, EventArgs e)
        {
            selectionPanel.Height = algorithm.Height;
            selectionPanel.Top = algorithm.Top;
            ParameterScreen screen = new ParameterScreen();
            screen.Show();
        }

        private void visualization_Click(object sender, EventArgs e)
        {
            selectionPanel.Height = visualization.Height;
            selectionPanel.Top = visualization.Top;
            if (FileOperations.path == "" || FileOperations.path.Equals("openFileDialog1")) MessageBox.Show("Please choose a file.", "File Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                Chart chart = new Chart();//Görselleştirme işlemleri için chart açılır
                chart.Show();
            }

        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                    {
                        m.Result = (IntPtr)0x2;
                    }
                    return;
            }
            base.WndProc(ref m);
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        } 
    }
}
