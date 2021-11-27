using System;
using System.Collections.Generic;
using System.IO;
using Genovich;

namespace ConsoleApp4
{
    class Program : SquareEquations
    {
        static void Main(string[] args)
        {
            SquareEquations equations = new SquareEquations();
            Console.WriteLine("Введите a, b, c: ");
            try
            {
                double a = Convert.ToDouble(Console.ReadLine());
                double b = Convert.ToDouble(Console.ReadLine());
                double c = Convert.ToDouble(Console.ReadLine());
                GenovichLog.getIntance().log("Введено уравнение " + a + "x^2 + " + b + "x + " + c);
                List<double> roots = equations.solve(a, b, c);
                GenovichLog.getIntance().log("Корни уравнения: " + string.Join(" ", roots)).write();
                
            }
            catch (GenovichException e)
            {
                GenovichLog.getIntance().log(e.Message);
            }
            catch (IOException e)
            {
                throw new Exception("Outer", e);
            }
            GenovichLog.getIntance().write();
        }
    }
}
