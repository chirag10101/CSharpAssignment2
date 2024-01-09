
namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Size of array");
            Int32.TryParse(Console.ReadLine(), out int n);
            int[] nums=new int[n];
            Console.WriteLine("Enter elements");
            for (int i = 0; i < n; i++)
            {
                Int32.TryParse(Console.ReadLine(), out nums[i]);
            }
            Console.WriteLine("Sum of Arr is"+Sum(nums));
            Console.WriteLine("MAx of arr is"+Program3.MaxOfArr(nums));
            Console.WriteLine("Sum of Matrix is :"+Program2.SumOfMatrix());
            Program4.SumOfColumns();
            Program5.SumOfRows();


        }

        static int Sum(params int[] nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            return sum;
        }

        
    }
}
