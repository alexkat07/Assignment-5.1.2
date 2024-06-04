namespace Assignment_5._1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CalculateSum(1234));

            int CalculateSum(int input) 
            {
                int sum = 0;    

                string convertToString = input.ToString();

                for (int i = 0; i  < convertToString.Length; i++) 
                {
                    int num = int.Parse(convertToString[i].ToString());
                    sum += num; 
                }
                return sum;
            }
        }
    }
}
