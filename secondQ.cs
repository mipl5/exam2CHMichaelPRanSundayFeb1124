public static int CommonMax(int number)
{
    int maxApp = 0;
    int maxAppNum = 0;
    while (number > 0)
    {
        int num = number % 10;
        int howMany = CountApp(num, number);
        if (howMany > maxApp)
        {
            maxApp = howMany;
            maxAppNum = num;
        }
        else if (howMany == maxApp)
        {
            if (maxAppNum > num)
            {
                maxAppNum = num;
            }
        }
        number /= 10;
    }
    return maxAppNum;
}
