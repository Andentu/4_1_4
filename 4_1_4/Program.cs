namespace _4_1_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 4.1.4
            string a = "text";
            string b = "btext";
            bool c = a != b;

            // Task 4.1.5
            int A = 43;
            int B = 64;
            double X = 32.3;
            double Y = 155.4;
            bool tr = (A < B) && (X > Y);
            if (tr == true)
            {
                Console.WriteLine("tr");
            }

            // Task 4.1.12
            if (A != B)
            {
                Console.WriteLine("Условие истинно");
            }
            else
            {
                Console.WriteLine("Условие ложно");
            }
        }
    }
}