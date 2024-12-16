namespace ASSIGNMENT_7_1_1
{
    internal class Program
    {
        static void SelectionSort(int[] scores)
        {
            int n = scores.Length;

            // Loop through each element in the array
            for (int i = 0; i < n - 1; i++)
            {

                //Find the minimum element in the unsorted part of the array 
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (scores[j] < scores[minIndex])
                    {
                        minIndex = j;
                    }
                }

                //Swap the found minimum element with the first element
                int temp = scores[minIndex];
                scores[minIndex] = scores[i];
                scores[i] = temp;
            }
        }

        //Function to print the sorted array
        static void PrintArray(int[] scores) 
        {
            foreach (int score in scores)
            {
                Console.WriteLine(score + " ");
            }
            Console.WriteLine();

        }


        static void Main()
        {
            //Sample exam scores
            int[] scores = { 100, 92, 54, 95, 88, 87, 98, 89 };

            Console.WriteLine("Original Scores:");
            PrintArray(scores);

            //Sort the scores using selection sort
            SelectionSort(scores);

            Console.WriteLine("Sorted Scores (Ascending Order):");
            PrintArray(scores);
        }
    }
}
