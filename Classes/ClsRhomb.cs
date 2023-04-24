using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFourangleClasses.Classes
{
    internal class ClsRhomb : ClsParallelogram

    {
        private double sideA;
        private double diagonal1;
        private double diagonal2;

        public void SidesCalculation()
        {
            sideA = Math.Sqrt((X1 - X2) * (X1 - X2) + (Y1 - Y2) * (Y1 - Y2));
            Console.WriteLine("Сторона ромба");
            Console.WriteLine($"Стороная A={Math.Round(sideA, 2)}");

        }
        public double Perimetr()
        {
            return 4 * sideA;
        }
        public void DiagonalsCalculation()
        {
            diagonal1 = Math.Sqrt((X1 - X3) * (X1 - X3) + (Y1 - Y3) * (Y1 -Y3));
            diagonal2 = Math.Sqrt((X2 - X4) * (X2 - X4) + (Y2 - Y4) * (Y2 - Y4));
            Console.WriteLine($"Диагональ1 ={Math.Round(diagonal1, 2)}");
            Console.WriteLine($"Диагональ2 ={Math.Round(diagonal2, 2)}");
        }

        public double Ploshad()
        {
            double s = 0;
            s = diagonal1 * diagonal2 / 2;
            return s;
            Console.WriteLine($"Площадь равна={Math.Round(s)}");
        }
       
    }
}
