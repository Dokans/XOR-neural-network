using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Neural_Network;

namespace XOR_winform
{
    public partial class XOR_Form : Form
    {

        private NeuralNetwork nn;
        private static Random rnd = new Random();
        private Task trainProcces;
        private CancellationTokenSource cancellationToken;
        double[][] inputData = new double[4][]
            {
                new double[]{1, 1 },
                new double[]{1, 0 },
                new double[]{0, 0 },
                new double[]{0, 1 },

            };
        double[][] targetData = new double[4][]
        {
                new double[]{0},
                new double[]{1},
                new double[]{0},
                new double[]{1},

        };

        public XOR_Form()
        {
            InitializeComponent();
        }

        private void FileSelect(object sender, EventArgs e)
        {
            

            try
            {
                DialogResult result = OpenNN.ShowDialog();
                
                nn = NeuralNetwork.Load(OpenNN.FileName);
                PanelCreateNN.Enabled = false;
                PanelNNOperator.Enabled = true;
                LabelNNFile.Text = OpenNN.FileName;
            }
            catch (Exception error)
            {
                LabelNNFile.Text = "Load your NN";
                PanelCreateNN.Enabled = true;
                MessageBox.Show("Couldn´t load NN");
            }
        }

        private void BtnCreateNewNN_Click(object sender, EventArgs e)
        {


            nn = new NeuralNetwork(2, GetHiddenLayers((int)numHiddenLayers.Value, (int)NumHLNodes.Value), 1);
            PanelCreateNN.Enabled = false;
            PanelNNOperator.Enabled = true;
        }


        private void NumHLNodes_ValueChanged(object sender, EventArgs e)
        {
            if (NumHLNodes.Value == 0)
            {
                btnCreateNewNN.Enabled = false;
            }
            else
            {
                btnCreateNewNN.Enabled = true;
            }
        }

        private void BtnTrain_Click(object sender, EventArgs e)
        {
            cancellationToken = new CancellationTokenSource();
            nn.SetLearningRate((double)NumLearningRate.Value);
            trainProcces = new Task(() => { IncTraining(); }, cancellationToken.Token);
            trainProcces.Start();
            BtnTrain.Enabled = false;
            BtnStopTraining.Enabled = true;
        }

        private void IncTraining()
        {
            try
            {
                while (!cancellationToken.Token.IsCancellationRequested)
                {
                    //pick random member
                    int element = rnd.Next(inputData.GetLength(0));

                    nn.Train(inputData[element], targetData[element]);
                    nn.Interation++;
                    if (nn.Interation % 1000 == 0)
                    {
                        Matrix output = nn.Predict(inputData[element]);

                        this.Invoke((MethodInvoker)delegate
                        {
                            if (Math.Abs(output.Data[0, 0] - targetData[element][0]) < Convert.ToDouble(errorLabel.Text.ToString()))
                            {
                                errorLabel.Text = Math.Round(Math.Abs(output.Data[0, 0] - targetData[element][0]), 4).ToString();
                            }
                            iterationCountLabel.Text = nn.Interation.ToString();
                        });
                    }

                }
            }
            catch (Exception e)
            {

            }

        }

        private void BtnStopTraining_Click(object sender, EventArgs e)
        {
            cancellationToken.Cancel();
            BtnTrain.Enabled = true;
            BtnStopTraining.Enabled = false;
        }

        private void BtnTry_Click(object sender, EventArgs e)
        {
            double[] inputs = new double[] { (double)NumInput1.Value, (double)NumInput2.Value };

            Matrix outputs = nn.Predict(inputs);

            LabelOutput.Text = Math.Round(outputs.Data[0, 0], 4).ToString();
        }

        private void BtnSaveNN_Click(object sender, EventArgs e)
        {
            if (!trainProcces.IsCompleted)
            {
                cancellationToken.Cancel();
            }

            try
            {
                DialogResult path = SaveNN.ShowDialog();

                nn.Save(SaveNN.FileName);

                MessageBox.Show("Your NN has been saved");

            }
            catch (Exception error)
            {
                MessageBox.Show("Something went wrong");
            }
        }

        private int[] GetHiddenLayers(int layers, int nodes)
        {
            int[] ret = new int[layers];

            for (int i = 0; i < ret.Length; i++)
            {
                ret[i] = nodes;
            }

            return ret;
        }
    }
}
