namespace DataStructures.Problems.MaximumSumSubarray_Kadane_s_Algorithm;

public class MaximumSumSubarray
{
    
    public static void Test()
    {
        int []arr = { -4, 2, -5, 1, 2, 3, 6, -5, 1 };
        int arrSize = arr.Length;
        int maxSum = MaxSumArr(arr, arrSize);
        Console.WriteLine("Maximum contiguous sum is " + maxSum);
    }
    
    private static int MaxSumArr(int []arr, int arrSize)
    {
        if (arrSize < 1)
        {
            return 0;
        }

        int currMax = arr[0];
        int globalMax = arr[0];

        for (int i = 1; i < arrSize; i++)
        {
            if (currMax < 0)
            {
                currMax = arr[i];
            }
            else
            {
                currMax += arr[i];
            }

            if (globalMax < currMax)
            {
                globalMax = currMax;
            }
        }
        return globalMax;
    }
    
}