using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouSource_SortStrategyPattern
{
    //STRATEGY
    abstract class SortStrategy
    {
        public abstract string Sort(string input);
    }

    //CONCRETE STRATEGY QUICKSORT AND BUBBLE SORT
    class QuickSort : SortStrategy
    {
        public override string Sort(string input)
        {
            char[] arr = input.ToCharArray();
            Array.Sort(arr);
            string output = new string(arr);

            return output;
        }
    }

    class BubbleSort : SortStrategy
    {
        public override string Sort(string input)
        {
            char[] arr = input.ToCharArray();
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (arr[j] > arr[j + 1])
                    {
                        char temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
            string output = new string(arr);

            return output;
        }
    }

    //CONTEXT
    class sortedList
    {
        private string _input;
        private SortStrategy _sortstrategy;

        public void SetSortStrategy(SortStrategy sortstrategy)
        {
            this._sortstrategy = sortstrategy;
        }

        public void setInput(string str)
        {
            _input = str;
        }

        public string Sort()
        {
            return _sortstrategy.Sort(_input);
        }

    }
}
