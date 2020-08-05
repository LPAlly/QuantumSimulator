using System;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;
using QuantumSimulator.Tools;

namespace QuantumSimulator.Models.Gates
{
    public class NOT
    {
        public int Id { get; set; }

        public Qbit InputQbit { get; set; }
        public Qbit OutputQbit { get; set; }

        private Matrix<double>  NOTMatrix = Matrix<double>.Build.DenseOfColumnArrays(new[] { 0.0, 1.0 }, new[] { 1.0, 0.0 });

        public NOT(Qbit inputQbit)
        {
            InputQbit = inputQbit;
            OutputQbit = new Qbit();
            NOTOperation();
        }

        public NOT()
        {
        }

        private void CalculateOutput()
        {
            OutputQbit = InputQbit;
        }

        private void NOTOperation()
        {
            OutputQbit.QbitState = InputQbit.QbitState.Transpose().Multiply(NOTMatrix).Transpose();
        }
    }
}
