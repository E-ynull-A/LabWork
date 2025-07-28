using System.Globalization;

namespace CheckTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 0, -5, 3, 12, 10 };
            Console.WriteLine(GetMin(nums));
            int[] new_nums = SortArray(nums);
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(new_nums[i]);
            }
        }
        
        static public int GetMin(int[] nums)
        {
            int min = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (min > nums[i])
                {
                    min = nums[i];
                }
            }
            return min;
            
        }
        static public int[] SortArray(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length - 1; j++)
                {

                    if (nums[j + 1] < nums[j])
                    {
                        int num = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = num;
                    }
                }
            }
            return nums;
        }
    }
}
