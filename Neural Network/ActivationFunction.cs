using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neural_Network
{
    [Serializable]
    public class ActivationFunction
    {
        public Func<double, double> func { get; set; }
        public Func<double, double> dfunc { get; set; }

        public ActivationFunction(Func<double, double> func, Func<double, double> dfunc)
        {
            this.func = func;
            this.dfunc = dfunc;
        }

        public ActivationFunction()
        {

        }
    }
}
