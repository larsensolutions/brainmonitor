using System;
using System.Windows.Forms;

namespace BrainMonitor
{
    public partial class NNSetup : Form
    {
        public int _inputLayer, _hiddenLayer, _outputLayer;
        private int _inputLayerP, _hiddenLayerP, _outputLayerP;
        

        public NNSetup()
        {
            InitializeComponent();
            _inputLayer  = 0;
            _hiddenLayer = 0;
            _hiddenLayer = 0;

            inputLayer_cb.SelectedIndex = 0;
            hiddenLayer_cb.SelectedIndex = 0;
            outputLayer_cb.SelectedIndex = 0;

            _inputLayerP = _inputLayer;
            _hiddenLayerP = _hiddenLayer;
            _outputLayerP = _outputLayer;        
        }

        private void NNSetup_Load(object sender, EventArgs e)
        {

        }
        private void ok_button_Click(object sender, EventArgs e)
        {
            _inputLayerP = _inputLayer;
            _hiddenLayerP = _hiddenLayer;
            _outputLayerP = _outputLayer;
            Hide();
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            _inputLayer = _inputLayerP;
            inputLayer_cb.SelectedIndex = _inputLayer;
            _hiddenLayer = _hiddenLayerP;
            hiddenLayer_cb.SelectedIndex = _hiddenLayer;
            _outputLayer = _outputLayerP;
            outputLayer_cb.SelectedIndex = _outputLayer;
            Hide();
        }

        private void inputLayer_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            _inputLayer = inputLayer_cb.SelectedIndex;
        }

        private void hiddenLayer_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            _hiddenLayer = hiddenLayer_cb.SelectedIndex;
        }

        private void outputLayer_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            _outputLayer = outputLayer_cb.SelectedIndex;
        }

    }
}
