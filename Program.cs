namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Task 1

            string name = "Malik";
            string surname = "Malikov";
            Console.WriteLine(name+" "+surname);

            //Task 2

            int a = 3;
            int b = 5;
            int sum = a + b;
            Console.WriteLine(sum);


            //Task 3

            int c = 3;
            int d = 5;
            int answer = c-d;
            Console.WriteLine(answer);

            //Task 4

            int int1 = 4;
            int int2 = 7;

            int output1 = int1 + int2;
            int output2 = output1 * output1;
            Console.WriteLine(output2);

            //Task 5

            double input1 = 18;
            double input2 = 5;
            double quotient = input1 / input2;
            double output= Math.Pow(quotient, 2);
            Console.WriteLine(output);


            Console.ReadKey();





        }

    }
}