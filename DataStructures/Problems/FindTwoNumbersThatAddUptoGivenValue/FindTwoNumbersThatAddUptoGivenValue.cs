namespace DataStructures.FindTwoNumbersthatAddUptoGivenValue;

public class FindTwoNumbersThatAddUptoGivenValue
{
    public static void Test()
    {
        int[] arr1 = new []{1,21,3,14,5,60,7,6};
        int value = 81;
        
        int[] solution = FindSum(arr1,value,arr1.Length);
    }
    

    #region Brute Force

    private static int[] FindSum(int []arr, int value, int size)
    {
        int[] solution = new int[2];

        for (int i = 0; i < size; i++)
        {
            for (int j = i + 1; j < size; j++)
            {
                if (arr[i] + arr[j] == value)
                {
                    solution[0] = arr[i];
                    solution[1] = arr[j];
                    return solution;
                }
            }
        }
        
        return arr; 
    }

    #endregion
    
}