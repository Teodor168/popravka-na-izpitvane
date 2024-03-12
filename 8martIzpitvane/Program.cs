namespace _8martIzpitvane
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// input
            Console.WriteLine("Dai chisla: ");
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            ///print
            Console.WriteLine(string.Join(", ", numbers));
            Console.WriteLine();
            Console.WriteLine(SrednoAretmetichno(numbers));
            Console.WriteLine();
            Console.WriteLine(Nuli(numbers));
            Console.WriteLine();
            ElementiNaMasiva(numbers);
            Console.WriteLine();
            Console.WriteLine(NaiBlizko(numbers, SrednoAretmetichno(numbers)));
        }///ACTION
        static double SrednoAretmetichno(int[] numbers)/// average
        {
            int result = 0;
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum / numbers.Length; ;
        }
        static int Nuli(int[] numbers)///nulite v masiva
        {
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 0)
                {
                    count++;
                }
            }
            return count;
        }
        static void ElementiNaMasiva(int[] numbers)/// elementite s indeksi
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"{i}------>{numbers[i]}");
            }
        }
        static int NaiBlizko(int[] numbers, double average)/// nai blizkoto do average
        {
            double diff = 0;
            double minDiff = double.MaxValue;
            int closest = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                diff = Math.Abs( average - numbers[i]);
                if (diff < minDiff)
                {
                    minDiff = diff;
                    closest = i;
                }
            }
            return closest;
        }
    }
  }