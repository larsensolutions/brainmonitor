using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZedGraph;
using BrainMonitor;

namespace BrainMonitor
{
    public partial class SampleGraph : Form
    {

        private PointPairList list, list2;
        private Sample sm;


        public SampleGraph(Sample sm)
        {
            InitializeComponent();
            list = new PointPairList();
            list2 = new PointPairList();
            this.sm = sm;
            frequencyList();
            if(!sm.isSample)sampleList(); 
        }


        public bool isComplete()
        {
            if (list != null && list2 != null) return true;
            return false;
        }

        private void generateAll(GraphPane gp)           
        {

            PointPairList list3 = new PointPairList();
/*
            for (int i = 0; i < 1024; i++)
            {
                double a = Math.Sin(2*Math.PI*10*i);
                addToList(list3, a);
            }
 */
            PointPairList list4 = new PointPairList();
            PointPairList list5 = new PointPairList();
            PointPairList list6 = new PointPairList();
            PointPairList list7 = new PointPairList();
            for(int i=0; i<sm.getSampleSize;i++){
                //addToList(list3, sm.twohzData[i]);
                //addToList(list4, sm.sixhzData[i]);
                //addToList(list5, sm.tenhzData[i]);
                //addToList(list6, sm.fiftheenhzhzData[i]);
                addToList(list7, sm.thrirtytwohzData[i]);
            }
            LineItem myCurve1 = gp.AddCurve("Delta", list3, Color.Blue, SymbolType.None);
            myCurve1.Line.IsSmooth = true;
            myCurve1.Line.IsOptimizedDraw = true;
            myCurve1.Line.IsAntiAlias = true;
            myCurve1.Line.SmoothTension = 0.5F;
            myCurve1.Line.Width = 2.5F;



            
            //myCurve1.Symbol.Fill = new Fill(Color.White);
            myCurve1.Symbol.Size = 0;
            LineItem myCurve2 = gp.AddCurve("Theta", list4, Color.Red, SymbolType.None);
            myCurve2.Line.IsSmooth = true;
            myCurve2.Line.IsOptimizedDraw = true;
            myCurve2.Line.IsAntiAlias = true;
            myCurve2.Line.SmoothTension = 0.5F;
            myCurve2.Line.Width = 2.5F;
            LineItem myCurve3 = gp.AddCurve("Alpha", list5, Color.Black, SymbolType.None);
            myCurve3.Line.IsSmooth = true;
            myCurve3.Line.IsOptimizedDraw = true;
            myCurve3.Line.IsAntiAlias = true;
            myCurve3.Line.SmoothTension = 0.5F;
            myCurve3.Line.Width = 2.5F;
            LineItem myCurve4 = gp.AddCurve("Beta", list6, Color.Green, SymbolType.None);
            myCurve4.Line.IsSmooth = true;
            myCurve4.Line.IsOptimizedDraw = true;
            myCurve4.Line.IsAntiAlias = true;
            myCurve4.Line.SmoothTension = 0.5F;
            myCurve4.Line.Width = 2.5F;
            LineItem myCurve5 = gp.AddCurve("Gamma", list7, Color.Purple, SymbolType.None);
            myCurve5.Line.IsSmooth = true;
            myCurve5.Line.IsOptimizedDraw = true;
            myCurve5.Line.IsAntiAlias = true;
            myCurve5.Line.SmoothTension = 0.5F;
            myCurve5.Line.Width = 2.5F;
            


        }

        private void frequencyList(){
             double[] drawData = sm.getFFTabsData;
             for (int i = 2; i < 102; i+=2)
             {
                 addToAttentionList((int)(((drawData[i] + drawData[i+1]) / sm.getPeak) * 100));
             }
        }

        private void sampleList()
        {
            double[] sampleData = sm.getRawData;
            for (int i = 0; i < sampleData.Length; i ++)
            {
                addToMeditationList(sampleData[i]);
            }
        }

        private void addToAttentionList(double num)
        {
            list.Add(list.Count + 1, num);
        }

        private void addToMeditationList(double num)
        {
            list2.Add(list2.Count + 1, num);
        }

        private void addToList(PointPairList list, double num)
        {
            list.Add(list.Count + 1, num);
        }

        private void InitGraph()
        {

            GraphPane pane = zedGraphControl1.GraphPane;
            pane.Chart.Fill = new Fill(Color.AntiqueWhite, Color.Honeydew, -45F);
            pane.Title.Text = "Frequency Spectrum";
            pane.XAxis.Title.Text = "Frequency";
            pane.YAxis.Title.Text = "Amplitude (V)";
            pane.XAxis.MajorGrid.IsVisible = true;
            pane.YAxis.MajorGrid.IsVisible = true;
            pane.YAxis.MajorGrid.Color = Color.LightGray;
            pane.XAxis.MajorGrid.Color = Color.LightGray;
            pane.XAxis.Scale.Max = 52;
            pane.XAxis.Scale.Min = 0;
            pane.YAxis.Scale.Min = 0;
            pane.YAxis.Scale.Max = 100;
            pane.CurveList.Clear();
            pane.Legend.IsVisible = false;
            pane.AxisChange();
            zedGraphControl1.Invalidate();

            GraphPane pane2 = zedGraphControl2.GraphPane;
            //pane2.Chart.Fill = new Fill(Color.AntiqueWhite, Color.Honeydew, -45F);
            pane2.Title.Text = "Sample - Recording";
            pane2.XAxis.Title.Text = "Time (x 10 ms)";
            pane2.YAxis.Title.Text = "Amplitude (mV)";
            pane2.XAxis.MajorGrid.IsVisible = true;
            pane2.YAxis.MajorGrid.IsVisible = true;
            pane2.YAxis.MajorGrid.Color = Color.LightGray;
            pane2.XAxis.MajorGrid.Color = Color.LightGray;
            pane2.XAxis.Scale.Max = sm.getSampleSize;
            pane2.XAxis.Scale.Min = 0;
            if (!sm.isSample)
            {
                pane2.YAxis.Scale.Min = -500;
                pane2.YAxis.Scale.Max = 500;
            }
            else
            {
                pane2.YAxis.Scale.Min = -10;
                pane2.YAxis.Scale.Max = 10;
            }
            //pane2.CurveList.Clear();
            //pane2.Legend.IsVisible = false;
            pane2.AxisChange();
            zedGraphControl2.Invalidate();

          
        }

        public void CreateChart()
        {
            InitGraph();
            GraphPane myPane = zedGraphControl1.GraphPane;
            GraphPane myPane2 = zedGraphControl2.GraphPane;

            // Set the title and axis labels
            myPane.Title.Text = "Frequency Spectrum";
            myPane.XAxis.Title.Text = "Frequency (Hz)";
            myPane.YAxis.Title.Text = "Amplitude (V)";

            //myPane.AddCurve("EEG data", list, Color.Blue);
            BarItem myCurve2=myPane.AddBar("EEG data", list, Color.Blue);
            //myPane.AddCurve("Red: Meditation", list2, Color.Red);
            //BarItem myCurve2 = myPane.AddBar("Theta", list2, Color.Red);
            if (!sm.isSample)
            {
                LineItem myCurve3 = myPane2.AddCurve("EEG data", list2, Color.Blue, SymbolType.None);
                myCurve3.Line.IsSmooth = true;
                myCurve3.Line.IsOptimizedDraw = true;
                myCurve3.Line.IsAntiAlias = true;
                myCurve3.Line.SmoothTension = 0.5F;
                myCurve3.Line.Width = 1.5F;
            }
            else
            {
                generateAll(myPane2);
            }
            // Fill the axis background with a color gradient
            myPane.Chart.Fill = new Fill(Color.White,
               Color.FromArgb(255, 255, 166), 45.0F);
            
            myPane2.Chart.Fill = new Fill(Color.White,
              Color.FromArgb(255, 255, 166), 45.0F);

            zedGraphControl1.AxisChange();

            zedGraphControl2.AxisChange();

            // expand the range of the Y axis slightly to accommodate the labels
            myPane.YAxis.Scale.Max += myPane.YAxis.Scale.MajorStep;

            myPane2.YAxis.Scale.Max += myPane2.YAxis.Scale.MajorStep;

            // Create TextObj's to provide labels for each bar
           // BarItem.CreateBarLabels(myPane, false, "");     
          
        }

        public void saveAttentionGraph(String path)
        {
            IOService.writeScenarioData(path,list, list2, "rendom", 0, 0, 0);
        }

        private void Save_Click(object sender, EventArgs e)
        {

            
        }
    }
    }

