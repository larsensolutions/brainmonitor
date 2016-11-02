using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.IO;
using ZedGraph;
using System.Xml;

namespace BrainMonitor
{
    /// <summary>
    /// Class for handeling all spesific IO. Save directory is C:\
    /// </summary>
    public static class DiskOperator
    {

        public static void writeAllData(String path, double[] raw, double[] fft, string sn, int number, int sampleNumber, int avg_att, int avg_med)
        {
            if (path == null) path = @"C:\";
            if (sn == "") sn = "default";
            StreamWriter file = new StreamWriter(path + sn + number + ".txt");
            file.WriteLine("" + raw.Length + "-" + sn + "-" + number+"-"+avg_att+"-"+avg_med);
            foreach (double d in raw)
            {
                file.WriteLine(d);
            }
            file.WriteLine("");
            foreach (double d in fft)
            {
                file.WriteLine(d);
            }

            file.Close();
        }
        public static void writePowerData(String path, double[] powers, string sn, int number, int avg_att, int avg_med)
        {
            if (path == null) path = @"C:\Documents and Settings\iseilbaat\My Documents\test_data\";
            if (sn == "") sn = "default";
            StreamWriter file = new StreamWriter(path + sn + number + ".txt");
            file.WriteLine(sn + "-" + number + "-" + avg_att + "-" + avg_med+"-"+powers.Length);
            foreach (double d in powers)
            {
                file.WriteLine(d);
            }
            file.Close();
        }

        public static void writePowerStatData(String path, double[] data, double att, double med, string sn)
        {
            if (path == null) path = @"C:\Documents and Settings\iseilbaat\My Documents\test_data\";
            if (sn == "") sn = "stat";
            StreamWriter file = new StreamWriter(path + sn + ".txt");
            file.WriteLine(sn + "-" + 0 + "-" + att + "-" + med + "-" + data.Length);
            foreach (double d in data)
            {
                file.WriteLine(d);
            }
            file.Close();
        }

        public static void readPowerData(String path, out double[] powers, out string sn, out int number,out int avg_att, out int avg_med)
        {
            StreamReader reader = new StreamReader(path);
            string[] info = reader.ReadLine().Split('-');
            sn = info[0];
            number = (int)Convert.ToDouble(info[1]);
            avg_att = (int)Convert.ToDouble(info[2]);
            avg_med = (int)Convert.ToDouble(info[3]);
            int s = (int)Convert.ToDouble(info[4]);
            powers = new double[s];
            for (int i = 0; i < s; i++)
            {
                String f = reader.ReadLine();
                powers[i] = Convert.ToDouble(f);
            }
            reader.Close();
        }


        public static void readAllData(string path, out double[] raw,
            out double[] fft, out string sn, out int number, out int sampleNumber, out int avg_att, out int avg_med)
        {
            StreamReader reader = new StreamReader(path);
            String[] path2 = path.Split('\\');
            string p2 = "";
            for (int i = 0; i < path2.Length-1; i++)
            {
                p2 += path2[i];
            }

            GUI.getInstance().saveSessionPath =p2;
            string[] info = reader.ReadLine().Split('-');

            sampleNumber =(int) Convert.ToDouble(info[0]);
            sn = info[1];
            number = Convert.ToInt16(info[2]);
            if (info.Length == 5)
            {
                avg_att = Convert.ToInt16(info[3]);
                avg_med = Convert.ToInt16(info[4]);
            }
            else
            {
                avg_att = 0;
                avg_med = 0;
            }
            raw = new double[sampleNumber];
            for (int i = 0; i < raw.Length; i++)
            {
                String f = reader.ReadLine();
                raw[i] = Convert.ToDouble(f);
            }

            reader.ReadLine();

            fft = new double[sampleNumber];
            for (int i = 0; i < fft.Length; i++)
            {
                String f = reader.ReadLine();
                fft[i] = Convert.ToDouble(f);
            }


            reader.Close();
        }

        public static string[] SelectTextFiles(string initialDirectory)
        {
            if (initialDirectory == null) initialDirectory = @"C:\Documents and Settings\iseilbaat\My Documents\test_data\";
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = true;
            dialog.Filter =
               "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            dialog.InitialDirectory = initialDirectory;
            dialog.Title = "Select sample text file";
            return (dialog.ShowDialog() == DialogResult.OK)
               ? dialog.FileNames : null;
        }

        public static string SelectTextFile(string initialDirectory)
        {
            if (initialDirectory == null) initialDirectory = @"C:\Documents and Settings\iseilbaat\My Documents\test_data\";
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = true;
            dialog.Filter =
               "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            dialog.InitialDirectory = initialDirectory;
            dialog.Title = "Select sample text file";
            
            return (dialog.ShowDialog() == DialogResult.OK)
               ? dialog.FileName : null;
        }

        public static void writeScenarioData(String path, PointPairList list, PointPairList list2, String title, int number, int avg_att, int avg_med)
        {
            if (path == null) path = @"C:\";
            if (title == null) title = "DefaultScenario";
            StreamWriter file = new StreamWriter(path + title + number +  ".txt");
            file.WriteLine("" + list.Count + "-" + title+ "-" + number+ "-" +avg_att +"-"+ avg_med);
            PointPairList.Enumerator l = list.GetEnumerator();
            while (l.MoveNext())
            {
                file.WriteLine(l.Current.Y);
            }

            file.WriteLine("");

            PointPairList.Enumerator l2 = list2.GetEnumerator();
            while (l2.MoveNext())
            {
                file.WriteLine(l2.Current.Y);
            }

            file.Close();
        }

        public static void readScenarioData(String path, out PointPairList list, out PointPairList list2, out String title, out int number, out int avg_att, out int avg_med)
        {
            StreamReader reader = new StreamReader(path);
            string[] info = reader.ReadLine().Split('-');

            number = (int)Convert.ToDouble(info[2]);
            title = info[1];
            if (info.Length == 5)
            {
                avg_att = Convert.ToInt16(info[3]);
                avg_med = Convert.ToInt16(info[4]);
            }
            else
            {
                avg_att = 0;
                avg_med = 0;
            }
          
            list = new PointPairList();
            for (int i = 0; i < Convert.ToInt32(info[0]); i++)
            {
                String f = reader.ReadLine();
                list.Add(new PointPair(i, Convert.ToInt16(f)));
            }

            reader.ReadLine();

            list2 = new PointPairList();
            for (int i = 0; i < Convert.ToInt32(info[0]); i++)
            {
                String f = reader.ReadLine();
                list2.Add(new PointPair(i, Convert.ToInt16(f)));
            }
            reader.Close();

        }

        public static void writeNNStats(string name)
        {
            if (name == "") name = "default";
            int d = DateTime.Now.Minute;
            int s = DateTime.Now.Second;
            int h = DateTime.Now.Hour;
            StreamWriter file = new StreamWriter(@"C:\nn"+h+d+s+".txt");
            file.WriteLine("Neural Netwok Statistics");
            /*
            foreach (double d in raw)
            {
                file.WriteLine(d);
            }
            file.WriteLine("");
            foreach (double d in fft)
            {
                file.WriteLine(d);
            }
            */
            file.Close();
        }
    }
}
//end of file