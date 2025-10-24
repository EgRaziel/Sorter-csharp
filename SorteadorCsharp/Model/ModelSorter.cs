using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SorteadorCsharp
{
    public class ModelSorter
    {
        public int StartNumber { get; set; }
        public int EndNumber { get; set; }
        public int Result { get; set; }

        public ModelSorter(int startNumber, int endNumber)
        {
            StartNumber = startNumber;
            EndNumber = endNumber;
        }

        public int SortNumber()
        {
            Random random = new();
            Result = random.Next(StartNumber, EndNumber + 1);
            return Result;
        }

        public int SortDifferentNumber()
        {
            Random random = new();
            int newResult = Result;

            // Repeats the sorting until a different number is found
            while (newResult == Result && EndNumber > StartNumber)
            {
                SortNumber();
            }

            return Result;
        }
    }
}