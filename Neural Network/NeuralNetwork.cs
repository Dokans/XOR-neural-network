using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Neural_Network
{
    [Serializable]
    public class NeuralNetwork
    {
        int Inputs { get; }
        int Outputs { get; }
        int[] HidenLayers { get; }
        public int Interation = 0;

        public Matrix[] Weights { get; set; }
        public Matrix[] Biases { get; set; }
        [XmlIgnore]
        public ActivationFunction ActivationFunction;
        public double LearningRate { get; set; }
        public NeuralNetwork()
        {

        }
        public NeuralNetwork(int inputs, int[] hidenLayers, int outputs)
        {
            this.Inputs = inputs;
            this.Outputs = outputs;
            this.HidenLayers = hidenLayers;

            Init();
            SetActivationFunction();
            SetLearningRate(0.1F);
        }

        public NeuralNetwork(int inputs, int hidenLayers, int outputs)
        {
            Inputs = inputs;
            Outputs = outputs;
            HidenLayers = new int[1] { hidenLayers };

            Init();
            SetActivationFunction();
            SetLearningRate(0.1F);
        }

        private void Init()
        {
            Weights = new Matrix[HidenLayers.Length + 1];
            Biases = new Matrix[HidenLayers.Length + 1];

            for (int j = 0; j < Weights.Length; j++)
            {
                if (j == 0)
                {
                    Weights[j] = new Matrix(HidenLayers[j], Inputs);
                    Biases[j] = new Matrix(HidenLayers[j], 1);
                }
                else if (j == Weights.Length - 1)
                {
                    Weights[j] = new Matrix(Outputs, HidenLayers[j - 1]);
                    Biases[j] = new Matrix(Outputs, 1);
                }
                else
                {
                    Weights[j] = new Matrix(HidenLayers[j], HidenLayers[j - 1]);
                    Biases[j] = new Matrix(HidenLayers[j], 1);
                }

                Weights[j].Randomize();
                Biases[j].Randomize();
            }
        }

        public Matrix Predict(double[] inputData)
        {
            Matrix inputs = Matrix.FromArray(inputData);


            Matrix output = ProcessLayer(inputs, 0, Weights.Length);


            return output;
        }

        public Matrix Predict(Matrix inputData)
        {
            Matrix output = ProcessLayer(inputData, 0, Weights.Length);

            return output;
        }

        public void Train(double[] inputData, double[] targetData)
        {
            Matrix inputs = Matrix.FromArray(inputData);
            Matrix targets = Matrix.FromArray(targetData);

            Matrix[] results = new Matrix[Weights.Length];

            for (int j = 0; j < results.Length; j++)
            {
                if (j == 0)
                {
                    results[j] = ProcessLayer(inputs, j, j + 1);
                }
                else
                {
                    results[j] = ProcessLayer(results[j - 1], j, j + 1);
                }
            }

            Matrix[] errors = new Matrix[Weights.Length];
            
            for (int j = results.Length - 1; j > 0; j--)
            {
                if (j == results.Length - 1)
                {
                    errors[j] = Matrix.Substract(targets, results[j]);

                    Matrix graidents = Matrix.Map(results[j], ActivationFunction.dfunc);
                    graidents.Multiply(errors[j]);
                    graidents.Multiply(LearningRate);

                    Matrix previousLayerOutputsT = results[j - 1].Tanspose();
                    Matrix deltasWeights = Matrix.Multiply(graidents, previousLayerOutputsT);

                    Weights[j].Add(deltasWeights);
                    Biases[j].Add(graidents);
                }
                else if (j == 0)
                {
                    Matrix nextLayerWeightsT = Weights[j + 1].Tanspose();
                    errors[j] = Matrix.Multiply(nextLayerWeightsT, errors[j + 1]);

                    Matrix graidents = Matrix.Map(results[j], ActivationFunction.dfunc);
                    graidents.Multiply(errors[j]);
                    graidents.Multiply(LearningRate);

                    Matrix previousLayerOutputsT = inputs.Tanspose();
                    Matrix deltasWeights = Matrix.Multiply(graidents, previousLayerOutputsT);

                    Weights[j].Add(deltasWeights);
                    Biases[j].Add(graidents);
                }
                else
                {
                    Matrix nextLayerWeightsT = Weights[j + 1].Tanspose();
                    errors[j] = Matrix.Multiply(nextLayerWeightsT, errors[j + 1]);

                    Matrix graidents = Matrix.Map(results[j], ActivationFunction.dfunc);
                    graidents.Multiply(errors[j]);
                    graidents.Multiply(LearningRate);

                    Matrix previousLayerOutputsT = results[j - 1].Tanspose();
                    Matrix deltasWeights = Matrix.Multiply(graidents, previousLayerOutputsT);

                    Weights[j].Add(deltasWeights);
                    Biases[j].Add(graidents);
                }
            }
        }


        private Matrix ProcessLayer(Matrix input, int layer, int limit)
        {
            if (layer < limit)
            {
                input = Matrix.Multiply(Weights[layer], input);
                input.Add(Biases[layer]);
                input.Map(ActivationFunction.func);

                return ProcessLayer(input, layer + 1, limit);

            }
            else
            {
                return input;
            }
        }

        private void SetActivationFunction()
        {

            ActivationFunction = new ActivationFunction(
                    (x) => (1 / (1 + Math.Exp(-x))),
                    (y) => y * (1 - y)
                );

        }

        public void SetActivationFunction(ActivationFunction function)
        {

            ActivationFunction = function;

        }

        public void SetLearningRate(double learningRate) => LearningRate = learningRate;

        public void Save(string path)
        {
            BinaryFormatter bf = new BinaryFormatter();
            using (FileStream fs = new FileStream(path, FileMode.Create))
            using (MemoryStream ms = new MemoryStream())
            {
                bf.Serialize(ms, this);
                ms.WriteTo(fs);
            }
        }

        public static NeuralNetwork Load(string path)
        {
            BinaryFormatter bf = new BinaryFormatter();
            using (FileStream fs = new FileStream(path, FileMode.Open))
            using (MemoryStream ms = new MemoryStream())
            {
                return (NeuralNetwork)bf.Deserialize(fs);
            }
        }

    }
}
