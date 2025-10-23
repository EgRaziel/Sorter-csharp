using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SorteadorCsharp.Controller
{
    public class ControllerSorter
    {
        public static void SortNumber(int startNumber, int endNumber, out int result)
        {
            ModelSorter modelSorter = new(startNumber, endNumber);
            modelSorter.SortNumber();
            result = modelSorter.Result;
        }

        public static void SortDifferentNumber(int startNumber, int endNumber, out int result)
        {
            ModelSorter modelSorter = new(startNumber, endNumber);
            modelSorter.SortDifferentNumber();
            result = modelSorter.Result;
        }
    }
}