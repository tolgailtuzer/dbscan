using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DBScan
{
    public partial class Chart : Form
    {
        public Chart()
        {
            InitializeComponent();
        }


        private void Chart_Load(object sender, EventArgs e)
        {
           foreach(String i in FileOperations.headers)//Chart formu yüklenirken x ve y eksenlerinin seçileceği comboboxlara headerlar atanır
            {
                axis1.Items.Add(i);
                axis2.Items.Add(i);
            }

            axis1.SelectedIndex = 0;
            axis2.SelectedIndex = 1;
            FillChart();//Ekran açıldığında chartta ilk kategoriler seçili gelir

        }

        private void visualize_Click(object sender, EventArgs e)
        {
            FillChart();
        }

        public void FillChart()
        {
            int counter = 1;
            int tempc;
            chart1.Series.Clear();
            foreach (var i in dbScan.mainCluster)//Kümeler charta eklenir
            {
                chart1.Series.Add(counter.ToString());
                chart1.Series[counter.ToString()].ChartType = SeriesChartType.Point;//Nokta grafiği oluşması sağlanır
                chart1.Series[counter.ToString()].MarkerStyle = MarkerStyle.Diamond;
                chart1.Series[counter.ToString()].MarkerSize = 12;
                tempc = 0;
                foreach (var j in i)
                {
                    chart1.Series[counter.ToString()].Points.AddXY(j.fArr[axis1.SelectedIndex], j.fArr[axis2.SelectedIndex]);
                    //Seçilen eksenlerin özellikleri nokta olarak eklenir
                    chart1.Series[counter.ToString()].Points[tempc].Tag = "Kayıt Id: " + j.id + " Atandığı Küme: " + dbScan.status[j.id];
                    //Chartta üzerine tıklandığında o noktanın bilgilerini göstermek üzere o noktanın tag ine bilgileri atanır
                    tempc++;
                }
                counter++;
            }
            chart1.Series.Add("Noise");
            chart1.Series["Noise"].ChartType = SeriesChartType.Point;
            chart1.Series["Noise"].MarkerSize = 12;
            int noiseCount = 0;
            foreach (var i in dbScan.status)//Sapan değerler charta eklenir
            {
                if (i.Value == "Noise")
                {
                    foreach (var find in FileOperations.data)
                    {
                        if (find.id == i.Key)
                        {
                            chart1.Series["Noise"].Points.AddXY(find.fArr[axis1.SelectedIndex], find.fArr[axis2.SelectedIndex]);
                            chart1.Series["Noise"].Points[noiseCount].Tag = "Kayıt Id: " + find.id + " Noise";
                            noiseCount++;
                            break;
                        }
                    }
                }
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
