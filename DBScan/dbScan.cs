using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBScan
{
    public struct Props//Elemanların id ve kategorilerini tutan struct
    {
        public int id;
        public double[] fArr;

    }
    class dbScan
    {
        public static List<List<Props>> mainCluster = new List<List<Props>>();//Sınıflandırma sonrası oluşan kümeler burada saklanır
        public static int noiseCount;//Sapan değer sayısını tutar
        public static Dictionary<int, string> status = new Dictionary<int, string>();//Elemanların güncel durumlarını tutar
        public void CreateSet(int minPts, double eps)//DBSCAN Algoritmasını uygular
        {
            mainCluster.Clear();
            status.Clear();
            List<Props> data = FileOperations.ReadData();//Dosyadan okunan bilgiler data listine aktarılır
            foreach (var i in data)//Bütün elemanların durum bilgisi nullanır
            {
                status[i.id] = null;
            }
            int clusterNumber = 0;
            
            foreach (var cur in data)
            {
                if (status[cur.id] == null)//Eğer eleman herhangi kümeye atanmamış ya da sapan değer değilse koşul sağlanır
                {
                    List<Props> neighbors = CheckNeighbors(data, cur, eps);//Güncel(cur) noktanın komşuları bulunur
                    if (neighbors.Count >= minPts)//Eğer komşu sayısı belirlenen minimum nokta sayısından büyükse veya eşitse koşul sağlanır
                    {
                        clusterNumber++;//Küme sayısı burada tutulur
                        status[cur.id] = clusterNumber.ToString();//Şuanki elemanın(cur) durum bilgisine kümenin idsi atanır
                        neighbors.Remove(cur);
                        List<Props> tempCluster = neighbors;
                        //foreach (var set in tempCluster.ToList())//Her komşu noktanın komşuları bulunur. Bulunan her nokta listeye eklenir ve 
                        for(int k=0;k<tempCluster.Count;k++)
                        {    //onların da komşuları bulunur listenin sonuna kadar bu olay tekrarlanır                  
                            if (status[tempCluster[k].id] == "Noise") status[tempCluster[k].id] = clusterNumber.ToString();//Eğer nokta sapan değerse durumu değiştirilerek küme idsi atanır
                            if (status[tempCluster[k].id] == null)//Eğer eleman herhangi kümeye atanmamış ya da sapan değer değilse koşul sağlanır
                            {
                                status[tempCluster[k].id] = clusterNumber.ToString();
                                List<Props> neighbors2 = CheckNeighbors(data, tempCluster[k], eps);//Şuanki değerin(set) komşuları bulunur
                                if (neighbors2.Count >= minPts)
                                {
                                    foreach(var cr in neighbors2)
                                    {
                                        if(!tempCluster.Contains(cr))tempCluster.Add(cr);
                                    }                                  
                                }
                            }
                        }
                        //if(!tempCluster.Contains(cur))tempCluster.Add(cur);
                    }
                    else//Noktanın komşu sayısı minimum pointsin altında kalırsa sapan değer olarak belirlenir
                    {
                        status[cur.id] = "Noise";
                    }
                }
                Console.Read();
            }
           
            for (int i = 1; i <=clusterNumber; i++)//Kümeler belirlendikten sonra statusta bütün elemanların sonuçta nereye atandığı veya noise olduğu tutulur
            {
                List<Props> temp = new List<Props>();
                foreach (var j in status)
                {
                    if (j.Value.Equals(i.ToString()))
                    {
                        foreach (var find in data)//Id eşleştiği takdirde data listesinden o elemanın Props nesnesi çekilir
                        {
                            if (j.Key == find.id)
                            {
                                temp.Add(find);
                                break;
                            }
                        }
                    }
                }
                if(temp.Count!=0)mainCluster.Add(temp);
            }
            noiseCount = 0;
            foreach (var i in status)//Sapan değer sayısı belirlenir
            {
                if (i.Value == "Noise") noiseCount++;
            }
        }

        public List<Props> CheckNeighbors(List<Props> data, Props cur, double eps)//Komşu nokta kontrolü burada yapılır
        {
            List<Props> neighbors = new List<Props>();
            foreach (var i in data)
            {              
                if (EuclideanDist(i, cur) <= eps)//Güncel noktanın bütün noktalara uzaklığı hesaplanır epsilondan küçük veya eşit olanlar listeye eklenir
                {
                    neighbors.Add(i);
                }
            }
            return neighbors;
        }
        public double EuclideanDist(Props p, Props q)//Her elemanın bütün özellikleri kullanılarak euclidean distance ı bulunur
        {
            double sum = 0;
            for (int i = 0; i < p.fArr.Length; i++)
            {
                sum += Math.Pow((q.fArr[i] - p.fArr[i]), 2);
            }
            return Math.Sqrt(sum);
        }
    }
}
