using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SorteadorCsharp.Model;

namespace SorteadorCsharp.Controller
{
    public class ControllerSorter
    {
        private static readonly ModelSorter modelSorter = new(); // Prevents the creation of a new instance with wrong values every time the method is called

        public static int SortNumber(int startNumber, int endNumber)
        {
            modelSorter.StartNumber = startNumber; // Updates the initial parameters of the modelSorter instance (started with default values)
            modelSorter.EndNumber = endNumber;

            return modelSorter.SortNumber();
        }

        public static int SortDifferentNumber(int startNumber, int endNumber)
        {
            modelSorter.StartNumber = startNumber;
            modelSorter.EndNumber = endNumber;

            return modelSorter.SortDifferentNumber();
        }
    }
}