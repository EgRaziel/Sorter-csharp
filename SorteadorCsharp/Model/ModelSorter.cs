using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SorteadorCsharp
{
    public class ModelSorter
    {
        private readonly Random random = new();
        
        public int StartNumber { get; set; }
        public int EndNumber { get; set; }
        public int Result { get; private set; }

        public ModelSorter()
        {

        }

        public ModelSorter(int startNumber, int endNumber)
        {
            StartNumber = startNumber;
            EndNumber = endNumber;
        }

        public int SortNumber()
        {
            Result = random.Next(StartNumber, EndNumber + 1);
            return Result;
        }

        public int SortDifferentNumber()
        {
            // Return StartNumber if user enters the same number as Initial Number and Final Number
            if (StartNumber == EndNumber)
            {
                return StartNumber;
            }
            
            int previousResult = Result;
            int newResult;

            do
            {
                newResult = SortNumber();
            } while (newResult == previousResult);

            return newResult;
        }
    }
}