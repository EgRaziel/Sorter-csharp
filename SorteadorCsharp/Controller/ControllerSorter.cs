using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SorteadorCsharp.Controller
{
    public class ControllerSorter
    {
        public static int SortNumber(int startNumber, int endNumber)
        {
            ModelSorter modelSorter = new(startNumber, endNumber);
            return modelSorter.SortNumber();
        }

        public static int SortDifferentNumber(int startNumber, int endNumber)
        {
            ModelSorter modelSorter = new(startNumber, endNumber);
            return modelSorter.SortDifferentNumber();
        }
    }
}