using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BrainMonitor
{
    class QuickSampleModel
    {
        private double[] powerBands;
        public int att, med;
        public double[] getPowerBands { get { return powerBands; } }

        public QuickSampleModel(double[] powers, int att, int med)
        {
            this.att = att;
            this.med = med;
            powerBands = new double[powers.Length];
            powerBands = powers;
            scale();
        }

        public QuickSampleModel(string path)
        {
            string dummy;
            int dummy1;
            DiskOperator.readPowerData(path, out powerBands, out dummy, out dummy1, out att, out med);
            //scale();
        }

        private void scale()
        {
            double high = 0;
            for (int i = 0; i < powerBands.Length; i++)
            {
                if (powerBands[i] > high)
                {
                    high = powerBands[i];
                }
            }
            for (int i = 0; i < powerBands.Length; i++)
            {
                powerBands[i] /= high; // Scale all bands with respect to peak, also, needs to fit the output of neural network
            }
        }
    }
}
