using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NeuronDotNet.Core;
using NeuronDotNet.Core.Backpropagation;

namespace BrainMonitor
{
    class NeuralNet
    {

        public enum LayerType
        {
            Linear,
            Sigmoid,
            Tanh,
        }

        private BackpropagationNetwork xorNetwork;
        private double[] errorList;
        private int cycles = 5000;
        private int neuronCount = 128;
        private double learningRate = 0.25d;
        private TrainingSet trainingSet;
        private int[] layerType = new int[3];

        public NeuralNet(int cycles, int neuronCount, double learinngRate, int[] layerType)
        {
            this.cycles = cycles;

            if (cycles < 1) { cycles = 1; }
			if (learningRate < 0.01) { learningRate = 0.01; }
            if (neuronCount < 1) { neuronCount = 1; }
            this.layerType = layerType;

        }

        public void addTrainingSet(double[] trainingData, double outPut)
        {
            trainingSet.Add(new TrainingSample(trainingData, new double[1] { outPut }));
        }

        public void makeNetwork(int trainingDataSize, int inputSize)
        {
            

            errorList = new double[cycles];

            ActivationLayer inputLayer = null;
            switch (layerType[0])
            {
                case 1:
                    inputLayer = new SigmoidLayer(inputSize);
                    break;
                case 2:
                    inputLayer = new TanhLayer(inputSize);
                    break;
                default:
                    inputLayer = new LinearLayer(inputSize);
                    break;
            }

            ActivationLayer hiddenLayer = null;
            switch (layerType[1])
            {
                case 1:
                    hiddenLayer = new TanhLayer(neuronCount);
                    break;
                case 2:
                    hiddenLayer = new LinearLayer(neuronCount);
                    break;
                default:
                    hiddenLayer = new SigmoidLayer(neuronCount);
                    break;
            }

            ActivationLayer outputLayer = null;
            switch (layerType[2])
            {
                case 1:
                    outputLayer = new TanhLayer(1);
                    break;
                case 2:
                    outputLayer = new LinearLayer(1);
                    break;
                default:
                    outputLayer = new SigmoidLayer(1);
                    break;
            }

            
           
            new BackpropagationConnector(inputLayer, hiddenLayer);
            new BackpropagationConnector(hiddenLayer, outputLayer);
            xorNetwork = new BackpropagationNetwork(inputLayer, outputLayer);
            xorNetwork.SetLearningRate(learningRate);
            

            trainingSet = new TrainingSet(trainingDataSize, 1);

        }

        public void train(ProgressBar progressBar){
            double max = 0d;

            xorNetwork.EndEpochEvent +=
            delegate(object network, TrainingEpochEventArgs args)
            {
                errorList[args.TrainingIteration] = xorNetwork.MeanSquaredError;
                max = Math.Max(max, xorNetwork.MeanSquaredError);
            };

            xorNetwork.EndEpochEvent +=
            delegate(object network, TrainingEpochEventArgs args)
               {
                errorList[args.TrainingIteration] = xorNetwork.MeanSquaredError;
                max = Math.Max(max, xorNetwork.MeanSquaredError);
                   progressBar.Value = (int)(args.TrainingIteration * 100d / cycles);
                };

            xorNetwork.Learn(trainingSet, cycles);
            double[] indices = new double[cycles];
            for (int i = 0; i < cycles; i++) { indices[i] = i; }

             xorNetwork.MeanSquaredError.ToString("0.000000");
        }

        public void Test(System.Windows.Forms.Label l, double[] data)
        {
            if (xorNetwork != null)
            {
                l.Text = xorNetwork.Run(data)[0].ToString("0.000000");
               
            }
            else
            {
                l.Text = "No network";
            }
        }

        public void Test(out float res, double[] data)
        {
            if (xorNetwork != null)
            {
                res = (float) xorNetwork.Run(data)[0];
            }
            else
            {
                res = 0.030303f;
            }
        }


    }
}
//end of file
