namespace git_lesson3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double operand1, operand2, result;

            Console.WriteLine("Введіть перше число: ");
            operand1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введіть друге число: ");
            operand2 = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Введіть знак арифметичної операції: ");
            string sign = Console.ReadLine();

            switch (sign)
            {
                case "+":
                    {
                        result = operand1 + operand2;
                        Console.WriteLine($" Сума чисел = {operand1} + {operand2} = {result}");
                        break;
                    }
                case "-":
                    {
                        result = operand1 - operand2;
                        Console.WriteLine($" Різниця чисел = {operand1} - {operand2} = {result}");
                        break;

                    }
                case "*":
                    {
                        result = operand1 * operand2;
                        Console.WriteLine($" Множник чисел = {operand1} * {operand2} = {result}");
                        break;
                    }
                case "/":
                    {
                        if (operand2 == 0)
                        {
                            Console.WriteLine("На нуль ділити не мона!!!");
                        }
                        else
                        {
                            result = operand1 / operand2;
                            Console.WriteLine($" Частка чисел = {operand1} / {operand2} = {result}");


                        }

                        break;

                    }



            }
            Console.ReadKey();

        }
    }
}