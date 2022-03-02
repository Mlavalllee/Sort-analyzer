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

        int[] CopyRandom = randomData;
        int[] Copyreversed = reversedData;
        int[] Copynearly = nearlySortedData;
        int[] copyunique = fewUniqueData;


        Bubble(randomData, CopyRandom, "RandomData");
        Bubble(reversedData, Copyreversed, "ReversedData");
        Bubble(nearlySortedData, Copynearly, "NearlySortedData");
        Bubble(fewUniqueData, copyunique, "FewUniqueData");
        Console.WriteLine("");
        Selection(randomData, CopyRandom, "RandomData");
        Selection(reversedData, Copyreversed, "ReversedData");
        Selection(nearlySortedData, Copynearly, "NearlySortedData");
        Selection(fewUniqueData, copyunique, "FewUniqueData");
        Console.WriteLine("");
        Insertion(randomData, CopyRandom, "RandomData");
        Insertion(reversedData, Copyreversed, "ReversedData");
        Insertion(nearlySortedData, Copynearly, "NearlySortedData");
        Insertion(fewUniqueData, copyunique, "FewUniqueData");

        void Bubble (int[] anArray, int[] CopyArray, String ArrayType)
        {
            var timer = new Stopwatch();
            timer.Start();
            BubbleSort(anArray);
            timer.Stop();
            anArray = CopyArray;
            Console.WriteLine($"Bubble Sort {ArrayType}: {timer.Elapsed}");
        }

        void Selection (int[] anArray, int[] CopyArray, String ArrayType)
        {
            var timer = new Stopwatch();
            timer.Start();
            SelectionSort(anArray);
            timer.Stop();
            anArray = CopyArray;
            Console.WriteLine($"Selection Sort {ArrayType}: {timer.Elapsed}");
        }

        void Insertion (int[] anArray, int[] CopyArray, String ArrayType)
        {
            var timer = new Stopwatch();
            timer.Start();
            InsertionSort(anArray);
            timer.Stop();
            anArray = CopyArray;
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
        for (int NumCompare = anArray.Length - 1; NumCompare > 0; NumCompare--)
        {
            for (int j = 0; j < NumCompare; j++)
            {
                if (anArray[j] > anArray[j + 1])
                {
                int NumSwap = anArray[j  + 1];
                anArray[j + 1] = anArray[j];
                anArray[j] = NumSwap;
                }
            }
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