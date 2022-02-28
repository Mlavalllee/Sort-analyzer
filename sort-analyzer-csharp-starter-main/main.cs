// Sort Analyzer Start Code

using System;
using System.IO;
using System.Diagnostics;

class MainClass
{
    public static void Main(string[] args)
    {
        // LOAD DATA FILES INTO ARRAYS
        int[] randomData = loadDataArray("data-files/random-values.txt");
        int[] reversedData = loadDataArray("data-files/reversed-values.txt");
        int[] nearlySortedData = loadDataArray("data-files/nearly-sorted-values.txt");
        int[] fewUniqueData = loadDataArray("data-files/few-unique-values.txt");

        // EXAMPLE OF TIMING DURATION OF A SORT ALGORITHM
        // var timer = new Stopwatch();
        // timer.Start();
        // bubbleSort(randomData);
        // timer.Stop();
        // Console.WriteLine($"Bubble Sort Random Data: {timer.Elapsed}");

        Bubble(randomData, "RandomData");
        Bubble(reversedData, "ReversedData");
        Bubble(nearlySortedData, "NearlySortedData");
        Bubble(fewUniqueData, "FewUniqueData");
        Console.WriteLine("");
        Selection(randomData, "RandomData");
        Selection(reversedData, "ReversedData");
        Selection(nearlySortedData, "NearlySortedData");
        Selection(fewUniqueData, "FewUniqueData");
        Console.WriteLine("");
        Insertion(randomData, "RandomData");
        Insertion(reversedData, "ReversedData");
        Insertion(nearlySortedData, "NearlySortedData");
        Insertion(fewUniqueData, "FewUniqueData");

        void Bubble (int[] anArray, String ArrayType)
        {
             var timer = new Stopwatch();
             timer.Start();
             BubbleSort(anArray);
             timer.Stop();
             Console.WriteLine($"Bubble Sort {ArrayType}: {timer.Elapsed}");
        }



        void Selection (int[] anArray, String ArrayType)
        {
            var timer = new Stopwatch();
            timer.Start();
            SelectionSort(anArray);
            timer.Stop();
            Console.WriteLine($"Selection Sort {ArrayType}: {timer.Elapsed}");
        }

        Console.WriteLine("");

        void Insertion (int[] anArray, String ArrayType)
        {
            var timer = new Stopwatch();
            timer.Start();
            InsertionSort(anArray);
            timer.Stop();
            Console.WriteLine($"Insertion Sort {ArrayType}: {timer.Elapsed}");
        }
    }

    // Function to create an array of integers from provided data file
    public static int[] loadDataArray(string fileName)
    {
        // Read Text File by Line 
        string[] lines = File.ReadAllLines(fileName);

        // Create Array of Integers
        int[] tempData = new int[lines.Length];
        for (int i = 0; i < lines.Length; i++)
        {
            tempData[i] = Convert.ToInt32(lines[i]);
        }

        // Return Array of Integers
        return tempData;
    }

    public static void BubbleSort(int[] anArray)
    {
        int NumCompare = anArray.Length - 1;
        for (int i = 0; i < anArray.Length; i++)
        {
            int Search = 0;
            for (int j = 0; j < NumCompare; j++)
            {
            Search++;
                if (anArray[j] > anArray[Search])
                {
                int NumSwap = anArray[Search];
                anArray[Search] = anArray[j];
                anArray[j] = NumSwap;
                }
            }
        NumCompare--;
        }
    }

    public static void SelectionSort(int[] anArray)
    {
        for (int FillPos = 0; FillPos < anArray.Length - 1; FillPos++)
        {
            int MinPos = FillPos;
            for (int i = FillPos + 1; i < anArray.Length; i++)
            {
                if (anArray[MinPos] > anArray[i])
                {
                    MinPos = i;
                }
            }
            int Swap = anArray[FillPos];
            anArray[FillPos] = anArray[MinPos];
            anArray[MinPos] = Swap;
        }

    }

    public static void InsertionSort(int[] anArray)
    {
        for (int i = 1; i < anArray.Length; i++)
        {
            int InsertVal = anArray[i];
            int InsertPos = i;
            while (InsertPos != 0 && anArray[InsertPos - 1] > InsertVal)
            {
                anArray[InsertPos] = anArray[InsertPos - 1];
                InsertPos--;
            }
            anArray[InsertPos] = InsertVal;
        }
    }
}