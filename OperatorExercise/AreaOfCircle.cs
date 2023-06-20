using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorExercise
{
    public class AreaOfCircle
    {
        public static double Calculate(double radius)
        {
            double formula = Math.PI * Math.Pow(radius, 2);
            return formula;
        }
    }
}
