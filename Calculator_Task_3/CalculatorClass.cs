namespace Calculator_Task_3
{
    public class CalculatorClass
    {
        public static double Calculate(string[] args)
        {
            double result = 0;
            try
            {
                if (args.Length != 3)
                {
                    throw new Exception("args.Length != 3");
                }

                double[] numbers = new double[args.Length - 1];
                string exp = string.Empty;
                for (int i = 0, j = 0; i < args.Length; i++)
                {
                    if (double.TryParse(args[i], out double num))
                    {
                        numbers[j] = num;
                        j++;
                    }
                    else if (args[i] == "+" || args[i] == "-")
                    {
                        exp = args[i];
                    }
                }

                if (numbers.Length != 2 || exp == string.Empty)
                {
                    throw new Exception("numbers.Length != 2 || exp != '+' || exp != '-'");
                }

                switch (exp)
                {
                    case "+":
                        result = numbers[0] + numbers[1];
                        break;
                    case "-":
                        result = numbers[0] - numbers[1];
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Environment.Exit(-1);
            }
            return result;
        }
    }
}
