using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;
using QuantumSimulator.Tools;
using QuantumSimulator.Models.Gates;

namespace QuantumSimulator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //try { Qbit A = new Qbit(0.0, 1.0); }
            //catch (System.ArgumentException ex) { Console.WriteLine(ex); }
            //Console.WriteLine(A);
            //NOT b = new NOT(A);

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
