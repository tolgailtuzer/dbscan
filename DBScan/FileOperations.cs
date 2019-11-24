using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBScan
{
    class FileOperations
    {
        public static List<Props> data = new List<Props>();//Dosyadan okunan bilgilerin tutulduğu liste. Üzerinde oynama yapılmayacağından ilk bilgilere buradan erişilir
        public static String[] headers;//Kategori başlıkları
        public static String path = "";
        public static CultureInfo culture = new CultureInfo("en");
        public static List<Props> ReadData()//Dosya okuma işlemleri yapılır
        {
            data.Clear();
            StreamReader sr = new StreamReader(path);
            string temp = sr.ReadLine();
            headers = temp.Split(',');
            int count = 1;
            while (temp != null)
            {
                temp = sr.ReadLine();
                if (temp == null) break;
                string[] split = temp.Split(',');
                Props tempProp = new Props();
                double[] tempArr = new double[split.Length];
                for (int i = 0; i < split.Length; i++)
                {
                    tempArr[i] = Double.Parse(split[i], culture);
                }
                tempProp.id = count;//Her elemanın özellikleri Props structı ile saklanır
                tempProp.fArr = tempArr;
                data.Add(tempProp);
                count++;
            }
            sr.Close();
            return data;
        }
        public static void JustResult()
        {
            ResultScreen resScreen = new ResultScreen();
            RichTextBox rich = resScreen.getTextArea();
            rich.Text = "";
            foreach (var i in dbScan.status)
            {
                if (i.Value == "Noise")
                {
                    rich.Text += "Record " + i.Key + ":      ?\n";
                }
                else
                {
                    rich.Text += "Record " + i.Key + ":      Cluster " + i.Value + "\n";
                }
            }
            int counter = 1;
            foreach (var i in dbScan.mainCluster)
            {
                rich.Text += "Cluster " + counter + ": " + i.Count + " Record\n";
                counter++;
            }
            rich.Text += "Outliers: " + dbScan.noiseCount;
            resScreen.Show();
        }
        public static void WriteData()//DBSCAN Algoritması uygulandıktan sonra dosyaya yazma işlemi gerçekleştirilir
        {
            StreamWriter sw = new StreamWriter("result.txt");
            ResultScreen resScreen = new ResultScreen();
            RichTextBox rich = resScreen.getTextArea();
            rich.Text = "";
            foreach (var i in dbScan.status)//Hangi elemanın sınıflandırma sonucu hangi kümeye atıldığı status dictionarysinde tutulur
            {//Hangi kayıdın hangi kümeye atıldığı dosyaya basılır
                if (i.Value == "Noise")
                {
                    sw.WriteLine("Record " + i.Key + ":      ?");
                    rich.Text += "Record " + i.Key + ":      ?\n";
                }
                else
                {
                    sw.WriteLine("Record " + i.Key + ":      Cluster " + i.Value);
                    rich.Text += "Record " + i.Key + ":      Cluster " + i.Value + "\n";
                }
            }
            int counter = 1;
            foreach (var i in dbScan.mainCluster)//Kümelerdeki toplam kayıt sayısı dosyaya basılır
            {
                sw.WriteLine("Cluster " + counter + ": " + i.Count + " Record");
                rich.Text += "Cluster " + counter + ": " + i.Count + " Record\n";
                counter++;
            }
            sw.WriteLine("Outliers: " + dbScan.noiseCount);//Sapan değerler dosyaya yazılır
            rich.Text += "Outliers: " + dbScan.noiseCount;
            resScreen.Show();
            sw.Close();
        }

    }
}
