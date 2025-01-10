namespace DataStructures.MergeTwoArrays;

public class MergeTwoArrays
{
    public static void Test()
    {
        int[] arr1 = new []{-3,0,1,4};
        int[] arr2 = new []{-9,-1,2,3,18};

        MergeArrays(arr1,arr2,arr1.Length,arr2.Length);
    }
    
    private static int[] MergeArrays(int[] arr1, int[] arr2, int arr1Size, int arr2Size)
    {
        int[] arr3 = new int[arr1Size + arr2Size]; // creating a new array

        int i = 0;
        int j = 0;
        int k = 0;

        Console.WriteLine(arr1);
        
        while (i < arr1Size && j < arr2Size)
        {
            if (arr1[i] < arr2[j])
            {
                arr3[k] = arr1[i];
                i++;
            }
            else
            {
                arr3[k] = arr2[j];
                j++;
            }

            k++;
        }

        while (i < arr1Size)
        {
            arr3[k] = arr1[i];
            i++;
            k++;
        }
        
        while (j < arr2Size)
        {
            arr3[k] = arr2[j];
            j++;
            k++;
        }


        return arr3;
    }
    
}