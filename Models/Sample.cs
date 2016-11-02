using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using BrainMonitor;

namespace BrainMonitor
{
    public class Sample : MindsetObserver
    {
        double[] rawData, fftData, fftAbsData, powerBands;
        private string name, highestBand;
        private int sampleSize, index, number, avg_med, avg_att;
        private double peak;
        bool finished = false;
        public bool isSample = false;

        public double[] twohzData, sixhzData, tenhzData, fiftheenhzhzData ,thrirtytwohzData;
         
        /// <summary>
        /// Creates an empty sampleModel that registers as a MindObserver and samples rawdata
        /// from the mindset until sampleSize is reached.
        /// </summary>
        /// <param name="sampleSize"></param>
        /// <param name="name"></param>
        /// <param name="number"></param>
        public Sample(int sampleSize, string name, int number)
        {
            rawData = new double[sampleSize];
            fftData = new double[sampleSize];
            fftAbsData = new double[sampleSize];
            powerBands = null;
            this.sampleSize = sampleSize;
            this.index = 0;
            this.name = name;
            this.number = number;
            avg_med = 0;
            avg_att = 0;
            peak = 0;
            GUI.getInstance().addMindObserver(this);
        }

        /// <summary>
        /// Load either a sample or a quicksample. Quicksamples do not carry raw data, only requency powers.
        /// set bool value to true for quicksample
        /// </summary>
        /// <param name="path"></param>
        /// <param name="quick"></param>
        public Sample(String path, bool quick)
        {
            if (!quick)
            {
                load(path);
                index = sampleSize;
                powerBands = null;
                fftAbsData = new double[sampleSize];
                if (GUI.getInstance().filter_cb.Checked)
                {

                    averageFilter(3);
                    resetFFTdata();
                    FFT(true);
                }
            }
            else
            {
                loadPowerSample(path);
            }
        }

        /// <summary>
        /// used to create spesific sample waves with a defined HZ and amplitude.
        /// </summary>
        /// <param name="sampleSize"></param>
        public Sample(int sampleSize)
        {
            this.sampleSize = sampleSize;
            rawData = new double[sampleSize];
            fftData = new double[sampleSize];
            fftAbsData = new double[sampleSize];
            twohzData= new double[sampleSize]; 
            sixhzData= new double[sampleSize]; 
            tenhzData= new double[sampleSize]; 
            fiftheenhzhzData= new double[sampleSize];
            thrirtytwohzData= new double[sampleSize];
            peak = 0;
            powerBands = null;
            make10HZsample();
            isSample = true;
        }

        public Sample(double[] powers, string name, int number, int att, int med)
        {
            sampleSize = 128;
            this.name = name;
            this.number = number;
            avg_med = att;
            avg_att = med;
            powerBands = new double[powers.Length+1];
            rawData = new double[sampleSize];
            fftData = new double[sampleSize];
            fftAbsData = new double[sampleSize];
            peak = 0;
            powerBands = powers;
            findHighestBand();
            for (int i = 0; i < powerBands.Length; i++)
            {
                powerBands[i] /= peak;//Scale all bands with respect to peak
            }
            if (GUI.getInstance().savemode_cb.Checked)savePowerSample(GUI.getInstance().saveSessionPath);
            GUI.getInstance().updateSampleView(this);
        }

        public void savePowerSample(string path)
        {
            IOService.writePowerData(path, getPowerBands, name, number, avg_att,avg_med);
        }
        public void loadPowerSample(string path)
        {
            IOService.readPowerData(path, out powerBands,out name,out number, out avg_att,out avg_med);
        }

        private void make10HZsample()
        {
            double T = 1d; // seconds
            double t = (double)(T / sampleSize);
            for (int i = 0; i < sampleSize; i++)
            {
                twohzData[i] = 5*(double) Math.Sin(2d * Math.PI * 2d *t*i); 
                sixhzData[i] = 4*(double) Math.Sin(2d * Math.PI * 6d *t*i); 
                tenhzData[i] = 4*(double) Math.Sin(2d * Math.PI * 10d *t*i);
                fiftheenhzhzData[i] = 7 * (double)Math.Sin(2d * Math.PI * 15d * t * i);
                thrirtytwohzData[i] = 2 * (double)Math.Sin(2d * Math.PI * 32d * t * i);

                rawData[i] = 5*(double) Math.Sin(2d * Math.PI * 2d *t*i);
                fftData[i] = 5*(double) Math.Sin(2d * Math.PI * 2d *t*i);
            }
        }

        public double[] getRawData { get { return rawData; } }
        public double[] getFFTabsData { get { return fftAbsData; } }
        public double[] getFFTData { get { return fftData; } }
        public double[] getPowerBands { get {
            if (powerBands == null) makePowerBand();
            return powerBands; 
        } }
        public double[] getSpesificPowerBands
        {
            get
            {
                if (powerBands == null) makeSpesificPowerBand();
                return powerBands;
            }
        }
        public string getName { get { return name+number; } }
        public int getSampleSize { get { return sampleSize; } }
        public double getPeak { get {
            return peak; } }
        public string getHighestBand{ get { return highestBand; } }

        public double[] getNNinput()
        {
            return new double[] { getPowerBands[0],getPowerBands[1], getPowerBands[2], getPowerBands[3], getPowerBands[4], avg_att};

        }

        public void resetFFTdata()
        {
            fftData = new double[sampleSize];
            powerBands = null;
            //fftData = (double[])rawData.Clone();
            int i = 0;
            foreach (double d in rawData)
            {
                fftData[i] = d;
                i++;
            }
        }

        public bool isSampleComplete()
        {
            return (index == sampleSize);
        }

        private void appendAttPoint(int ap)
        {
            avg_att += ap;
        }

        private void appendMedPoint(int mp)
        {
           avg_med += mp;
        }

        private void appendSamplePoint(float rd)
        {
            rawData[index] = (double)rd;
            fftData[index] = (double)rd;           
        }

        public void FFT(bool forward)
        {
            LomontFFT.getInstance().FFT(fftData, forward);
        }

        public void save(string path)
        {
            IOService.writeAllData(path, rawData, fftData, name, number, sampleSize, avg_att, avg_med);
        }

        private void load(String path)
        {
            IOService.readAllData(path,out rawData,out fftData,out name, out number,out sampleSize, out avg_att, out avg_med);
            
        }

        public void averageFilter(int range)
        {
            if(range%2==0)range++;
            if (rawData.Length > 0)
            {
                int startpos = (int)Math.Ceiling((double)(range/2.0));
                int step = range - startpos;
                for (int i = startpos; i < rawData.Length - step; i++)
                {
                    double d = 0;
                    for (int j = - step; j < step; j++)
                    {
                        d += rawData[i + j];
                    }
                    if(d!=0)rawData[i] = (double) (d / range);
                }
               }
        }

        public void makePowerBand()
        {
            powerBands = new double[5];
            for (int i = 2; i < 102; i++)
            {
                fftAbsData[i] = Math.Abs(fftData[i]);

                if (i < 8) powerBands[0] += fftAbsData[i]; //Delta
                else if (i < 15) powerBands[1] += fftAbsData[i]; //Theta
                else if (i < 25) powerBands[2] += fftAbsData[i]; //Alpha
                else if (i < 61) powerBands[3] += fftAbsData[i]; //Beta
                else powerBands[4] += fftAbsData[i]; //Gamma
            }
            //first data in table is of no use
            fftAbsData[0] = 0;
            fftAbsData[1] = 0;
            findHighestBand();
           
            for (int i = 0; i < powerBands.Length; i++)
            {
                powerBands[i] /= peak; //Scale all bands with respect to peak
            }

            /*
            //Testing just alpha channel
            getPowerBands[0]=0;
            getPowerBands[1] = 0;
            getPowerBands[3] = 0;
            getPowerBands[4] = 0;'
             */
        }

        public void adjust()
        {
            if (powerBands.Length < 6)
            {
                //make delta considerable less
                powerBands[0] *= 0.5;

                powerBands[1] *= 1.3;
                //make alpha greater influence
                powerBands[2] *= 1.2;
                //make gamma2 less also, slightly
                powerBands[4] *= 0.95;

            }
            else
            {
                //make alpha greater influence
                powerBands[4] *= 1.5;
                powerBands[3] *= 1.2;
                //make gamma2 less also, slightly
            }
        }

        public void makeSpesificPowerBand()
        {
            powerBands = new double[8];
            for (int i = 2; i < 102; i++)
            {
                fftAbsData[i] = Math.Abs(fftData[i]);

                if (i < 8) powerBands[0] += fftAbsData[i]; //Delta
                else if (i < 15) powerBands[1] += fftAbsData[i]; //Theta
                else if (i < 20) powerBands[2] += fftAbsData[i]; // Alpha 1
                else if (i < 25) powerBands[3] += fftAbsData[i]; // Alpha 2
                else if (i < 35) powerBands[4] += fftAbsData[i]; // Beta 1
                else if (i < 62) powerBands[5] += fftAbsData[i]; // Beta 2
                else if (i < 82) powerBands[6] += fftAbsData[i]; // Gamma 1
                else powerBands[7] += fftAbsData[i]; // Gamma 2
            }
            fftAbsData[0] = 0;
            fftAbsData[1] = 0;
            findHighestBand();

            for (int i = 0; i < powerBands.Length; i++)
            {
                powerBands[i] /= peak;//Scale all bands with respect to peak
            }
            //powerBands[5] = 0;
           // adjust();
        }

        public double[] getFFTAbsDataRange(int start, int end)
        {
            double[] r = new double[end - start];
            for (int i = 0; i < (end-start); i++)
            {
                r[i] = getFFTabsData[i + start];
            }
            r[0] = 0;
            r[1] = 0;
            return r;        
        }

        private void findHighestBand()
        {
            double high = 0;
            int index = 0;
            for (int i = 0; i < powerBands.Length; i++)
            {
                if (powerBands[i] > high)
                {
                    high = powerBands[i];
                    index = i;
                }
            }
            peak = high;
            switch (index)
            {
                case 0:
                    highestBand = "Delta";
                    break;
                case 1:
                    highestBand = "Theta";
                    break;
                case 2:
                    highestBand = "Alpha";
                    break;
                case 3:
                    highestBand = "Beta";
                    break;
                case 4:
                    highestBand = "Gamma";
                    break;
                default:
                    highestBand = "Error";
                    break;
            }
        }
        /*
        private String findDominatingFreq(int[] power)
        {
            //float high = k.ThinkGearState.Delta;
            float high = 0;
            int index = -1;
            float[] n = { k.ThinkGearState.Theta, k.ThinkGearState.Alpha1, k.ThinkGearState.Alpha2, k.ThinkGearState.Beta1, k.ThinkGearState.Beta2, k.ThinkGearState.Gamma1, k.ThinkGearState.Gamma2 };
            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] > high)
                {
                    high = n[i];
                    index = i;
                }
            }
            switch (index)
            {
                case 0:
                    return "Theta";
                case 1:
                    return "Alpha1";
                case 2:
                    return "Alpha2";
                case 3:
                    return "Beta1";
                case 4:
                    return "Beta2";
                case 5:
                    return "Gamma1";
                case 6:
                    return "Gamma2";
                default:
                    return "Delta";
            }
        }
         *
         **/

        public void thinkgearChanged(ThinkGearNET.ThinkGearChangedEventArgs e)
        {
            if (!isSampleComplete())
            {

                appendAttPoint((int)e.ThinkGearState.Attention);
                appendMedPoint((int)e.ThinkGearState.Meditation);
                appendSamplePoint(e.ThinkGearState.Raw);

                index++;
            }
            else
            {
                GUI.getInstance().removeMindObserver(this);
                if (GUI.getInstance().filter_cb.Checked) averageFilter(3);
                FFT(true);
                cleanUp();
                GUI.getInstance().updateSampleView(this);
                if (GUI.getInstance().savemode_cb.Checked)
                {
                    save(GUI.getInstance().saveSessionPath);
                    if (GUI.getInstance()._nnSetup.quicksamples_cb.Checked) savePowerSample(GUI.getInstance().saveSessionPath+@"\pd\");
                }
            }
        }

        public void cleanUp()
        {
            if (!finished)
            {
                avg_med /= index;
                avg_att /= index;
                finished = true;
            }
        }
    }
}
//end of file