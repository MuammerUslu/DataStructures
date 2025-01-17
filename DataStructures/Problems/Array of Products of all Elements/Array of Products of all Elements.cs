namespace DataStructures.Problems.Array_of_Products_of_all_Elements;

public class Array_of_Products_of_all_Elements
{
    // Implement a function findProduct(int arr[], int size), which takes an array arr and its size as an input,
    // and returns an array so that each index has a product of all the numbers present in the array except the number stored at that index.

    public static void Test()
    {
        FindProduct(new int[] { 2, -4, 3, -6, 1, 5, 6 }, 7);
    }

    private static int[] FindProduct(int[] arr, int size)
    {
        int n = size;
        int i, temp = 1;
        int[] product = new int[n];  // Allocate memory for the product array
        // temp contains product of elements on left side excluding arr[i]
        for (i = 0; i < n; i++)
        {
            product[i] = temp;
            temp *= arr[i];
        }
        temp = 1;  // Initialize temp to 1 for product on right side

        // temp contains product of elements on right side excluding arr[i]
        for (i = n - 1; i >= 0; i--)
        {
            product[i] *= temp;
            temp *= arr[i];
        }
        return product;
    }
}