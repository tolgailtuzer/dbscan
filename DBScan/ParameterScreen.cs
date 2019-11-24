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
    public partial class ParameterScreen : Form
    {
        public ParameterScreen()
        {
            InitializeComponent();
        }
        CultureInfo culture = new CultureInfo("en");
        private void startAlgorithm_Click(object sender, EventArgs e)
        {
            try
            {
                double eps;
                int minPoints;
                eps = double.Parse(epsilon.Text, culture);
                //Epsilon değeri kullanıcıdan alınır yanlış formatta bir değer girerse hata mesajı verilir
                if (!int.TryParse(minPts.Text, out minPoints)) throw new Exception("minPoints must be Int!!!");
                //Minimum nokta değeri kullanıcıdan alınır yanlış formatta bir değer girerse hata mesajı verilir
                dbScan start = new dbScan();
                start.CreateSet(minPoints, eps);//DBSCAN Algoritması başlatılır
                if (createLog.Checked)
                {
                    FileOperations.WriteData();//Oluşan kümeler dosyaya yazılır
                    MessageBox.Show("File created.","Log Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    FileOperations.JustResult();
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Please check your parameters.","Parameter Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
