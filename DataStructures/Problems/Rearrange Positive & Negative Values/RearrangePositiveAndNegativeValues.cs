namespace DataStructures.Problems.afsd;

public class RearrangePositiveAndNegativeValues
{
    public static void Test()
    {
        ReArrange(new int[] { 2, -4, 3, -6, 1, 5, 6 }, 7);
        ReArrange2(new int[] { 2, -4, 3, -6, 1, 5, 6 }, 7);
    }
    
    private static void ReArrange2(int[] arr, int size) 
    { 
        int j = 0; 
        for (int i = 0; i < size; i++)
        { 
            if (arr[i] < 0) {   // if negative number found
                if (i != j) 
                    (arr[i], arr[j]) = (arr[j], arr[i]);
                j++; 
            } 
        } 
    } 
    
    private static void ReArrange(int[] arr, int size)
    {
        int i= 0;
        int j = size - 1;
      
        bool stopLeft = false;
        bool stopRight = false;
      
        while(j >= i)
        {
            if(arr[i]>=0)
            {
                stopLeft = true;
            }
            else
            {
                i++;
            }
        
            if(arr[j]<=0)
            {
                stopRight = true;
            }
            else
            {
                j--;
            }
        
            if(stopLeft && stopRight)
            {
                stopLeft = false;
                stopRight = false;
                (arr[i], arr[j]) = (arr[j], arr[i]);
                i++;
                j--;
            }
        }
    }
}