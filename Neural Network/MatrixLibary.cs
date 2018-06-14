using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neural_Network
{
    [Serializable]
    public class Matrix
    {
        public static Random Random = new Random();
        public int Rows;
        public int Cols;
        public double[,] Data;

        public Matrix()
        {

        }

        public Matrix(int rows, int cols)
        {
            this.Rows = rows;
            this.Cols = cols;

            Data = new double[rows, cols];


        }

        public static Matrix FromArray(double[] inputArray)
        {
            Matrix result = new Matrix(inputArray.Length, 1);


            result.Map((int j, int k) => inputArray[j]);

            return result;
        }

        public double[,] ToArray()
        {

            return Data;

        }

        public void Add(double n)
        {
            Map((x, j, k) => x + n);
        }

        public void Add(Matrix m)
        {
            if (Rows != m.Rows || Cols != m.Cols)
            {
                return;
            }
            Map((x, j, k) => x + m.Data[j, k]);
        }

        public void Substract(double n)
        {
            Map((x, j, k) => x - n);
        }

        public void Substract(Matrix m)
        {
            if (Rows != m.Rows || Cols != m.Cols)
            {
                return;
            }
            Map((x, j, k) => x - m.Data[j, k]);
        }

        public void Multiply(double n)
        {
            Map((x, j, k) => x * n);
        }


        public void Multiply(Matrix m)
        {
            if (Rows != m.Rows || Cols != m.Cols)
            {
                return;
            }

                Map((double x, int j, int k) => x * m.Data[j, k]);
        }

        public void Divide(double n)
        {
            Map((double x, int j, int k) => x / n);
        }

        public void Divide(Matrix m)
        {
            if (Rows != m.Rows || Cols != m.Cols)
            {
                return;
            }
            Map((double x, int j, int k) => x / m.Data[j, k]);
        }


        public static Matrix Add(Matrix m1, Matrix m2)
        {
            Matrix result = new Matrix(m1.Rows, m1.Cols);

            result.Map((int j, int k) => m1.Data[j, k] + m2.Data[j, k]);

            return result;
        }

        public static Matrix Substract(Matrix m1, Matrix m2)
        {
            Matrix result = new Matrix(m1.Rows, m1.Cols);

            result.Map((int j, int k) => m1.Data[j, k] - m2.Data[j, k]);

            return result;
        }

        public static Matrix Multiply(Matrix m1, Matrix m2)
        {
            if (m1.Cols != m2.Rows)
            {
                return default(Matrix);
            }

            Matrix result = new Matrix(m1.Rows, m2.Cols);

            result.Map((double e, int i, int j) =>
            {
                double sum = 0;
                for (int k = 0; k < m1.Cols; k++)
                {
                    sum += m1.Data[i, k] * m2.Data[k, j];
                }
                return sum;
            });


            return result;
        }

        public static Matrix Divide(Matrix m1, Matrix m2)
        {
            Matrix result = new Matrix(m1.Rows, m1.Cols);

            result.Map((int j, int k) => m1.Data[j, k] / m2.Data[j, k]);

            return result;
        }

        public void Randomize()
        {

            Map(() => Random.NextDouble() * 2 - 1);
        }

        public Matrix Tanspose()
        {
            Matrix ret = new Matrix(Cols, Rows);
            ret.Map((double x, int j, int k) =>  Data[k ,j]);

            return ret;
        }

        public void Map(Func<double, int, int, double> func)
        {
            for (int j = 0; j < Rows; j++)
            {
                for (int k = 0; k < Cols; k++)
                {
                    double value = Data[j, k];
                    Data[j, k] = func(value, j, k);
                }
            }
        }

        public void Map(Func<int, int, double> func)
        {
            for (int j = 0; j < Rows; j++)
            {
                for (int k = 0; k < Cols; k++)
                {
                    Data[j, k] = func(j, k);
                }
            }
        }

        public void Map(Func<double> func)
        {
            for (int j = 0; j < Rows; j++)
            {
                for (int k = 0; k < Cols; k++)
                {
                    Data[j, k] = func();
                }
            }
        }

        public void Map(Func<double, double> func)
        {
            for (int j = 0; j < Rows; j++)
            {
                for (int k = 0; k < Cols; k++)
                {
                    double value = Data[j, k];
                    Data[j, k] = func(value);
                }
            }
        }

        public static Matrix Map(Matrix m, Func<double, double> func)
        {
            Matrix ret = new Matrix(m.Rows, m.Cols);
            for (int j = 0; j < ret.Rows; j++)
            {
                for (int k = 0; k < ret.Cols; k++)
                {
                    double value = m.Data[j, k];
                    ret.Data[j, k] = func(value);
                }
            }

            return ret;
        }


        public static Matrix operator *(Matrix a, Matrix b)
        {
            return null;
        }
    }
}
