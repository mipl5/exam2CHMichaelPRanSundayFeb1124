static void Main(string[] args)
{
    MyGoodCode();
}
public static void MyGoodCode()
{
    int[] numbers = { 7, 2, 5, 15, 4, 3, 4, 7, 5, 29, 11, 2 };
    char[] ops = { '*', '+', '/', '-', '+', '*', '-', '/' };
    double[] results = Calc(numbers, ops);
    Print(numbers, ops, results);
    Console.ReadKey();
}

private static void Print(int[] numbers, char[] ops, double[] results)
{
    int indexOps = 0;
    int indexResults = 0;
    for (int i = 0; i < numbers.Length; i += 3)
    {
        int firstNumber = numbers[i];
        char firstOperation = ops[indexOps];
        int secondNumber = numbers[i + 1];
        char secondOperation = ops[indexOps + 1];
        int thirdNumber = numbers[i + 2];
        Console.WriteLine("{0}{1}{2}{3}{4}={5}", firstNumber, firstOperation, secondNumber, secondOperation, thirdNumber, results[indexResults]);
        indexOps += 2;
        indexResults++;
    }
}

private static double[] Calc(int[] numbers, char[] ops)
{
    double[] results = new double[ops.Length / 2];
    int indRes = 0;
    int indOps = 0;
    for (int i = 0; i < numbers.Length; i += 3)
    {
        int firstNum = numbers[i];
        int secondNum = numbers[i + 1];
        int thirdNum = numbers[i + 2];
        if (ops[indOps] == '*' && ops[indOps + 1] == '*')
            results[indRes] = firstNum * secondNum * thirdNum;
        else if (ops[indOps] == '/' && ops[indOps + 1] == '/')
            results[indRes] = firstNum / (double)secondNum / thirdNum;
        else if (ops[indOps] == '-' && ops[indOps + 1] == '-')
            results[indRes] = firstNum - secondNum - thirdNum;
        else if (ops[indOps] == '+' && ops[indOps + 1] == '+')
            results[indRes] = firstNum + secondNum + thirdNum;
        else if (ops[indOps] == '*' && ops[indOps + 1] == '/')
            results[indRes] = firstNum * secondNum / (double)thirdNum;
        else if (ops[indOps] == '*' && ops[indOps + 1] == '-')
            results[indRes] = firstNum * secondNum - thirdNum;
        else if (ops[indOps] == '*' && ops[indOps + 1] == '+')
            results[indRes] = firstNum * secondNum + thirdNum;
        else if (ops[indOps] == '/' && ops[indOps + 1] == '*')
            results[indRes] = firstNum / (double)secondNum * thirdNum;
        else if (ops[indOps] == '/' && ops[indOps + 1] == '-')
            results[indRes] = firstNum / (double)secondNum - thirdNum;
        else if (ops[indOps] == '/' && ops[indOps + 1] == '+')
            results[indRes] = firstNum / (double)secondNum + thirdNum;
        else if (ops[indOps] == '-' && ops[indOps + 1] == '*')
            results[indRes] = firstNum - secondNum * thirdNum;
        else if (ops[indOps] == '-' && ops[indOps + 1] == '/')
            results[indRes] = firstNum - secondNum / (double)thirdNum;
        else if (ops[indOps] == '-' && ops[indOps + 1] == '+')
            results[indRes] = firstNum - secondNum + thirdNum;
        else if (ops[indOps] == '+' && ops[indOps + 1] == '*')
            results[indRes] = firstNum + secondNum * thirdNum;
        else if (ops[indOps] == '+' && ops[indOps + 1] == '/')
            results[indRes] = firstNum + secondNum / (double)thirdNum;
        else if (ops[indOps] == '+' && ops[indOps + 1] == '-')
            results[indRes] = firstNum + secondNum - thirdNum;
        indRes++;
        indOps += 2;
    }
    return results;
}
