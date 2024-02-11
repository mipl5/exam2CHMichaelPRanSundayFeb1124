public static int[,] GenerateEnchanted(int rows, int cols, int[] enchantedNums, int from, int to)
{
    int[,] enchantedMat = new int[rows, cols];
    for (int i = 0; i < enchantedMat.GetLength(0); i++)
    {
        int[] enchantedRow = GenerateEnchantedRow(enchantedNums, cols, from, to);
        for (int j = 0; j < enchantedRow.Length; j++)
        {
            enchantedMat[i, j] = enchantedRow[j];
        }
    }
    return enchantedMat;
}
public static int[] GenerateEnchantedRow(int[]enchantedNums, int n, int from, int to)
{
    Random rnd = new Random();
    int[] enchantedRow = new int[n];
    int lengthEnchatedNumsArr = enchantedNums.Length;
    int[] randomIndexes = GenerateRandomIndexesForEnchantedNums(n,lengthEnchatedNumsArr);
    for (int i = 0; i < randomIndexes.Length; i++)
    {
        int index = randomIndexes[i];
        enchantedRow[index] = enchantedNums[i];
    }
    for (int i = 0; i < enchantedRow.Length; i++)
    {
        bool CheckIndexInRandomIndexes = IsContains(i, randomIndexes);
        if (!CheckIndexInRandomIndexes)
            enchantedRow[i] = rnd.Next(from, to + 1);
    }
    return enchantedRow;
}

public static bool IsContains(int indexToCheck, int[] randomIndexes)
{
    bool isExist = false;
    for (int i = 0; i < randomIndexes.Length && !isExist; i++)
        if (indexToCheck == randomIndexes[i])
            isExist = true;
    return isExist;
}

public static int[] GenerateRandomIndexesForEnchantedNums(int n, int lengthEnchatedNumsArr)
{
    int[] randomIndexArr = new int[lengthEnchatedNumsArr];
    Initizalize(randomIndexArr);
    for (int i = 0; i < randomIndexArr.Length; i++)
    {
        int number = GetValidIndex(n, randomIndexArr);
        randomIndexArr[i] = number;
    }
    return randomIndexArr;
}
public static void Initizalize(int[] randomIndexArr)
{
    for (int i = 0; i < randomIndexArr.Length; i++)
    {
        randomIndexArr[i] = -1;
    }
}
public static int GetValidIndex(int n, int[] randomIndexArr)
{
    Random rnd = new Random();
    int indexRand = -1;
    bool isExist = true;
    while (isExist)
    {
        indexRand = rnd.Next(0, n);
        bool isExistAlreadyInRandomInd = IsIndexAreadyExistInRandomIndexArr(indexRand, randomIndexArr);
        if (!isExistAlreadyInRandomInd)
            isExist = false;
    }
    return indexRand;
}

public static bool IsIndexAreadyExistInRandomIndexArr(int numberRand, int[] randomIndexArr)
{
    bool isExist = false;
    for (int i = 0; i < randomIndexArr.Length && !isExist; i++)
        if (numberRand == randomIndexArr[i])
            isExist = true;
    return isExist;
}
