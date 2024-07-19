class Program
{
    static void Main()
    {
        Console.Clear();

        bool iscalcing = true;

        Console.WriteLine("Calculate? (Y/N)");
        string calculate = Console.ReadLine().ToUpper();

        if (calculate == "Y")
        {
            iscalcing = true;
        }
        else if (calculate == "N")
        {
            iscalcing = false;
        }

        while (iscalcing)
        {
            Console.WriteLine(" -- SUperC Cool iNTEGeer calcuaor -- ");
            Console.WriteLine(" ");
            Console.WriteLine(" eNTER INT 1");
            float num1;
            while (!float.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }

            //---------------------------------------------------------------//
            Console.WriteLine(" eNTER INT 2");
            float num2;
            while (!float.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }

            Console.WriteLine("WhaT OperAtIoN TO PerFoRM? (+,-,x,/)");
            Console.WriteLine("---------------------------------------------------------------");

            string nuse = Console.ReadLine();

            if (!string.IsNullOrEmpty(nuse) && nuse.Length == 1)
            {
                char mathop = nuse[0];
                float result = 0;
                bool validOperation = true;

                switch (mathop)
                {
                    case '+':
                        result = num1 + num2;
                        break;
                    case '-':
                        result = num1 - num2;
                        break;
                    case 'x':
                    case '*':
                        result = num1 * num2;
                        break;
                    case '/':
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                        }
                        else
                        {
                            Console.WriteLine("Error: Division by zero is not allowed.");
                            validOperation = false;
                        }
                        break;
                    default:
                        Console.WriteLine("----- That is not an applicable operation -----");
                        validOperation = false;
                        break;
                }

                if (validOperation)
                {
                    Console.WriteLine($"Result: {result}");
                }
            }
            else
            {
                Console.WriteLine("----- That is not an applicable operation -----");
            }

            Console.WriteLine("Calculate again? (Y/N)");
            string iscl = Console.ReadLine().ToUpper();

            if (iscl == "Y")
            {
                iscalcing = true;
            }
            else
            {
                iscalcing = false;
            }
        }

        Console.ReadKey();
    }
}