using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using ThinkGearNET;
using System.Windows.Forms;
using ZedGraph;
using BrainMonitor;

namespace BrainMonitor
{
    public partial class AttentionGraph : Form, MindsetObserver
    {
        private PointPairList list, list2;
        private int number;
        private String name;
        private int avg_med, avg_att;
        private bool restored = false;

        public AttentionGraph(String name, int number)
        {
            InitializeComponent();
            list = new PointPairList();
            list2 = new PointPairList();
            this.name = name;
            this.number = number;
            
        }

        public AttentionGraph(String path)
        {
            InitializeComponent();
            IOService.readScenarioData(path, out list,out list2,out name,out number, out avg_att, out avg_med);
            restored = true;
        }

        public bool isComplete()
        {
            if (list != null && list2 != null) return true;
            return false;
        }

        public void thinkgearChanged(ThinkGearChangedEventArgs e)
        {
            

                addToAttentionList((int)e.ThinkGearState.Attention);
                addToMeditationList((int)e.ThinkGearState.Meditation);

            
        }
        private void addToAttentionList(int num)
        {
            list.Add(list.Count + 1, num);
            avg_att += num;
        }

        private void addToMeditationList(int num)
        {
            list2.Add(list2.Count + 1, num);
            avg_med += num;
        }

        private void InitGraph()
        {

            GraphPane pane = zedGraphControl1.GraphPane;
            pane.Chart.Fill = new Fill(Color.AntiqueWhite, Color.Honeydew, -45F);
            pane.Title.Text = "Attention";
            pane.XAxis.Title.Text = "Time";
            pane.YAxis.Title.Text = "Level";
            pane.XAxis.MajorGrid.IsVisible = true;
            pane.YAxis.MajorGrid.IsVisible = true;
            pane.YAxis.MajorGrid.Color = Color.LightGray;
            pane.XAxis.MajorGrid.Color = Color.LightGray;
            pane.XAxis.Scale.Max = list.Count;
            pane.XAxis.Scale.Min = 0;
            pane.YAxis.Scale.Min = 0;
            pane.YAxis.Scale.Max = 100;
            pane.CurveList.Clear();
            pane.Legend.IsVisible = false;
            pane.AxisChange();
            zedGraphControl1.Invalidate();
        }

        public void CreateChart()
        {
            InitGraph();
            GraphPane myPane = zedGraphControl1.GraphPane;

            // Set the title and axis labels
            myPane.Title.Text = "Blue: Attention and Red: Meditation";
            myPane.XAxis.Title.Text = "Time";
            myPane.YAxis.Title.Text = "Level";

            /*
            PointPairList list = new PointPairList();
            PointPairList list2 = new PointPairList();
            
            Random rand = new Random();

            // Generate random data for three curves
            for (int i = 0; i < 10; i++)
            {
                double x = (double)i;
                double y = rand.NextDouble() * 100;
                double y2 = rand.NextDouble() * 100;
                list.Add(x, y);
                list2.Add(x, y2);
            }

             */

            // create the curves
            //BarItem myCurve = myPane.AddBar("Delta", list, Color.Blue);
            
            myPane.AddCurve("Blue: Attention", list, Color.Blue);
            myPane.AddCurve("Red: Meditation", list2, Color.Red);
            //BarItem myCurve2 = myPane.AddBar("Theta", list2, Color.Red);



            // Fill the axis background with a color gradient
            myPane.Chart.Fill = new Fill(Color.White,
               Color.FromArgb(255, 255, 166), 45.0F);

            zedGraphControl1.AxisChange();

            // expand the range of the Y axis slightly to accommodate the labels
            myPane.YAxis.Scale.Max += myPane.YAxis.Scale.MajorStep;

            // Create TextObj's to provide labels for each bar
            BarItem.CreateBarLabels(myPane, false, "f0");

            if (!restored)
            {
                avg_att /= list.Count;
                avg_med /= list2.Count;
            }
            avg_att_lev_lb.Text =""+avg_att;
            avg_med_lev_lb.Text=""+avg_med;
            

        }

        public void saveAttentionGraph(String path)
        {
            IOService.writeScenarioData(path,list, list2, name, number, avg_att, avg_med);
        }
    }
}
