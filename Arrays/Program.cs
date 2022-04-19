
public class Program
{
    public static void Main()
    {
        int[] nums;

        //nums = new int[5]{-7,-3,2,3,11};
        //DisplayArray(nums);
        //DisplayArray(SortedSquares(nums));

        nums = new int[8] { 1, 0, 2, 3, 0, 4, 5, 0 };
        DisplayArray(nums);
        DuplicateZeros(nums);
        DisplayArray(nums);
    }

    public static int[] SortedSquares(int[] nums)
    {
        int[] result = new int[nums.Length];

        int l = 0;
        int h = nums.Length - 1;
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            result[i] = nums[l] * nums[l] > nums[h] * nums[h] ? nums[l] * nums[l++] : nums[h] * nums[h--];
        }
        return result;
    }

    public static void DuplicateZeros(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] != 0)
                continue;
            for (int j = arr.Length - 1; j > i; j--)
            {
                arr[j] = arr[j - 1];
            }
            arr[i + 1] = arr[i++];
        }
    }

    public static void DisplayArray(int[] arr)
    {
        Console.Write("[ ");
        foreach (int num in arr)
        {
            Console.Write($"{num} ");
        }
        Console.WriteLine("]");
    }
}