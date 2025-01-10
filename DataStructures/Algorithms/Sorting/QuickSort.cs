namespace DataStructures.QuickSort;

public class QuickSort
{
    private static int _loopCount = 0;

    public static void Test()
    {
        // int[] arr = { 10, 2, 30, 4, 50, 6 };
        
        int[] arr = { 1, 2, 3, 4, 5, 6 };


        Console.WriteLine("Array: " + string.Join(", ", arr));

        Sort(arr, 0, arr.Length - 1);
        Console.WriteLine("Sorted Array: " + string.Join(", ", arr));

        Console.WriteLine($"Loop Count: {_loopCount}");
        Console.WriteLine($"n- log(n): {arr.Length * Math.Log2(arr.Length)}");
    }

    private static void Sort(int[] arr, int left, int right)
    {
        if (left < right)
        {
            // Diziyi pivot etrafında böl ve pivotun doğru yerini bul
            int pivotIndex = Partition(arr, left, right);

            // Sol ve sağ alt dizilerde rekürsif olarak sıralama yap
            Sort(arr, left, pivotIndex - 1);
            Sort(arr, pivotIndex + 1, right);
        }
    }

    private static int Partition(int[] arr, int left, int right)
    {
        // Pivot elemanını seç (genellikle sağdaki eleman seçilir)
        int pivot = arr[right];
        int i = left - 1; // Pivotun doğru yerini tutacak değişken

        for (int j = left; j < right; j++)
        {
            _loopCount++;

            
            if (arr[j] < pivot)
            {
                i++;
                // Daha küçük elemanları sola taşı
                Swap(arr, i, j);
            }
        }

        // Pivotu doğru yerine taşı
        Swap(arr, i + 1, right);
        return i + 1; // Pivotun yeni indeksi
    }

    private static void Swap(int[] arr, int a, int b)
    {
        (arr[a], arr[b]) = (arr[b], arr[a]);
        Console.WriteLine("Array - step: " + string.Join(", ", arr));
    }
}