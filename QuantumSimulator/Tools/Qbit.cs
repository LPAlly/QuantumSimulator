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
            QbitState = Matrix<double>.Build.DenseOfColumnArrays(new[] { zeroStateValue }, new[] { oneStateValue });
        }
    }
}
