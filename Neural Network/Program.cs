using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Neural_Network
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
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

            NeuralNetwork nn;
            Double learningRate;

            if (File.Exists("data.bin"))
            {
                nn = NeuralNetwork.Load("data.bin");
                learningRate = nn.LearningRate;
            }
            else
            {
                int[] hL = { 10, 10 };

                nn = new NeuralNetwork(2, hL, 1);
                learningRate = 0.3;
            }



            double bestFit = 1;
            bool pass = true;

            while (pass)
            {
                nn.SetLearningRate(learningRate);
                for (int i = 0; i < 10000; i++)
                {
                    int element = rnd.Next(inputData.GetLength(0));
                    nn.Train(inputData[element], targetData[element]);


                    Matrix outputs = nn.Predict(new double[] { 0, 1 });
                    double output = outputs.Data[0, 0];

                    nn.Interation++;

                    if (output < bestFit)
                    {
                        bestFit = output;
                    }
                    if (nn.Interation % 1000 == 0)
                    {

                        Console.WriteLine("C: {0} |     | B:{1}", output, bestFit);

                    }

                }

                Console.WriteLine("Poslední LR {0} |     | Počet učení {1}", learningRate, nn.Interation);

                string input = Console.ReadLine();
                if (input == "q")
                {
                    pass = false;
                }
                else if (input != "")
                {
                    learningRate = Double.Parse(input);
                }

            }

            Console.WriteLine("Uložit NN? (A/N)");
            if (Console.ReadLine() == "A")
            {
                nn.Save("data.bin");
            }
        }
    }


}
