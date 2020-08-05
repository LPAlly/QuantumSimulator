using System;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;

namespace QuantumSimulator.Tools
{
    public class Qbit
    {
        public Matrix<double> QbitState;

        public Qbit(double zeroStateValue, double oneStateValue)
        {
            ValideValue(zeroStateValue, oneStateValue);
            QbitState = Matrix<double>.Build.DenseOfColumnArrays(new[] { zeroStateValue, oneStateValue });
            
        }

        public Qbit()
        {
            QbitState = Matrix<double>.Build.DenseOfColumnArrays(new[] { double.NaN, double.NaN });

        }

        public override string ToString()
        {
            return QbitState[0, 0].ToString() + "|0> + " + QbitState[1, 0].ToString() +"|1>";
        }

        private void ValideValue(double zeroStateValue, double oneStateValue)
        {

            if (((zeroStateValue * zeroStateValue) + (oneStateValue * oneStateValue)) != 1)
            { 
                throw new ArgumentException("The square of the amplitudes should be 1");
            }
        }
    }
}
