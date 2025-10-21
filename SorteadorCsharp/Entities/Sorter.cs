using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SorteadorCsharp
{
    public class Sorter
    {
        public int StartNumber { get; set; }
        public int EndNumber { get; set; }
        public int Result { get; private set; }

        public Sorter(int startNumber, int endNumber)
        {
            StartNumber = startNumber;
            EndNumber = endNumber;
        }

        public void SortNumber()
        {
            Random random = new Random();
            Result = random.Next(StartNumber, EndNumber + 1);
        }

        public void SortDifferentNumber()
        {
            Random random = new Random();
            int newResult = Result;

            // Repeats the sorting until a different number is found
            while (newResult == Result && EndNumber > StartNumber)
            {
                newResult = random.Next(StartNumber, EndNumber + 1);
            }

            Result = newResult;
        }
    }
}