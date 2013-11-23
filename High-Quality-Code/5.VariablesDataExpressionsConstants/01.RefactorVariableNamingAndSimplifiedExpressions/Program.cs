using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.RefactorVariableNamingAndSimplifiedExpressions
{
    class Program
    {
        static void Main()
        {
            FigureSize figure = new FigureSize(5, 6);
            FigureSize.GetRotatedFigureSize(figure, 90);
        }
    }
}
